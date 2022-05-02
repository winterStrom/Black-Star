using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float waitTime;
    public Transform[] movePos;
    private int i;
    private Transform playerTransform;
    void Start()
    {
        i = 1;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,movePos[i].position,speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,movePos[i].position)<0.1f)
        {
            if(waitTime <0.0f)
            {
                if(i == 0)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                waitTime = 0.5f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
    public  void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.BoxCollider2D")
        {
            other.gameObject.transform.parent = gameObject.transform;
        }    
    }
       public  void OnTriggerExit2D(Collider2D other) 
    {
        
        if(other.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.BoxCollider2D")
        {
            other.gameObject.transform.parent = playerTransform;
        }    
    }
}
