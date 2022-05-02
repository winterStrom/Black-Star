using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySmartBat : Enemy
{
    public float speed;
    public float radius;

    public Transform playerTransform;
    public Transform[] RandonPos;
    public Transform movePos;
    public float startWaitTime;
    private float waittime;
    private bool canlookplayer;

    // Start is called before the first frame update
    public void Start()
    {
        base.Start();
        waittime = startWaitTime;
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        movePos.position = GetRandPos();
    }

    // Update is called once per frame
    public void Update()
    {
        //调用父类的Update()方法
        base.Update();
        if (playerTransform != null)
        {
            float distance = Vector2.Distance(transform.position,playerTransform.position);

            if(distance < radius)
            {
                transform.position = Vector2.MoveTowards(transform.position, 
                                                        playerTransform.position,
                                                        speed * Time.deltaTime);
            }
            else
            {
                RandomMove();
            }
        }
        OnDrawGizmos();
    }
    public void RandomMove()
    {
        
        transform.position = Vector2.MoveTowards(transform.position,movePos.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,movePos.position) < 0.1f)
        {
            if(waittime <= 0)
            {
               movePos.position = GetRandPos();
               waittime = startWaitTime;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }
    public Vector2 GetRandPos()
    {
        Vector2 rndPos = new Vector2(Random.Range(RandonPos[0].position.x,RandonPos[1].position.x),Random.Range(RandonPos[0].position.y,RandonPos[1].position.y));
        return rndPos;
    }
    void OnDrawGizmos()//绘制辅助线
    {
        Gizmos.color = Color.red;//辅助线颜色
        Gizmos.DrawWireSphere((Vector2)transform.position,radius);
    }
}

