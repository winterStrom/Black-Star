using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damage;
    public float speed;
    public float arrawDistance;

    private Rigidbody2D rg2d;
    private Vector3 startPos;

    // Use this for initialization
   public void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        rg2d.velocity = transform.right * speed;
        startPos = transform.position;
    }

   public void Update()
    {
        float distance = (transform.position - startPos).sqrMagnitude;
        if (distance > arrawDistance)
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
