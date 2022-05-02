using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyVFX : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animation;
    public int damage;
    public float speed;
    public float arrawDistance;

    private Rigidbody2D rg2d;
    private Vector3 startPos;

    // Use this for initialization
   public void Start()
    {
        animation = GetComponent<Animator>();
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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            animation.SetBool("Boom",true);
            rg2d.velocity = Vector2.zero;
            Destroy(gameObject ,0.5f);
            other.GetComponent<Enemy>().TakeDamage(damage);
            
        }
    }
}
