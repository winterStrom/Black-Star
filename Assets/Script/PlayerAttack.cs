using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int damage;
    public float time;
    public float startTime;
    private Animator anim;
    private PolygonCollider2D collider2D;
    private PlayerInputActions controls;
    void Awake() 
    {
        controls = new PlayerInputActions();
        controls.GamePlayer.Attack.started += ctx => Attack();  
    }
    void OnEnable() 
    {
        controls.GamePlayer.Enable();
    }
    void OnDisable() 
    {
        controls.GamePlayer.Disable();
    }
    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        collider2D = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Attack();
    }
    private void Attack()
    {
        //if(Input.GetButtonDown("Attack"))
        {
            collider2D.enabled = true;
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
            anim.SetTrigger("Attack");
            StartCoroutine(StartAttack());
            }
            
        }
        
    }
    IEnumerator StartAttack()
    {
        yield return new WaitForSeconds(startTime);
        collider2D.enabled = true;
        StartCoroutine(disableHitBox());
    }
    IEnumerator disableHitBox()
    {
        yield return new WaitForSeconds(time);
        collider2D.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.gameObject.CompareTag("Enemy"))
       {
           other.GetComponent<Enemy>().TakeDamage(damage);
       } 
    }
}
