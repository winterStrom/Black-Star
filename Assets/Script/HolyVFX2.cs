using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyVFX2 : MonoBehaviour
{
    
    public float speed;
    public int damage;
    public float arrawDistance;

    private Rigidbody2D rg2d;
    private Vector3 startPos;
    public Transform monsterTran;

    // Use this for initialization
   public void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        monsterTran = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        startPos = transform.position;
        
    }

   public void Update()
    {
        float distance = (transform.position - startPos).sqrMagnitude;
        if (distance < arrawDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position,monsterTran.position,speed*Time.deltaTime);
            Destroy(gameObject,0.5f);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}
