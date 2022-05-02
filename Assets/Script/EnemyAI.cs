using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 200f;
    public float nextWayppointDistance = 3f;
    public float radialLength;
    private Path path;
    private int currentWaypoint = 0;
    private bool reachedEndOfPath = false;
    private Seeker seeker;
    private Rigidbody2D rb;
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdatePath",0f,0.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }
        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        if(Vector2.Distance(rb.position,target.position) <= radialLength)
        {
            UpdatePath();
            Move();
        }
        float distance = Vector2.Distance(rb.position,path.vectorPath[currentWaypoint]);
        if(distance < nextWayppointDistance)
        {
            currentWaypoint++;
        }
        OnDrawGizmos();
    }
      public void Move()
    {
        
        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;
        rb.velocity = force;
    }
      public void UpdatePath()
    {
        if(seeker.IsDone())
        seeker.StartPath(rb.position,target.position,OnPathComplete);
    }
    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }
    void OnDrawGizmos()//绘制辅助线
    {
        Gizmos.color = Color.red;//辅助线颜色
        Gizmos.DrawWireSphere((Vector2)transform.position, radialLength);
    }
}
