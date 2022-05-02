using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int blinks;
    public float seconds;
    public float dieTime;
    public float hitBoxCDTime;
    private Renderer myRenderer;
    private Animator anim;
    private ScreenFlash sf;
    private Rigidbody2D rb2D;
    private PolygonCollider2D polygonCollider2D;
    void Start()
    {
        HealthBar.healthMax = health;
        HealthBar.healthCurrent = health;
        myRenderer = GetComponent<Renderer>();
        anim = GetComponent<Animator>();
        sf = GetComponent<ScreenFlash>();
        rb2D = GetComponent<Rigidbody2D>();
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamagePlayer(int damage)
    {
        sf.FlashScreen();
        health -= damage;
        if(health < 0)
        {
            health = 0;
        }
        HealthBar.healthCurrent = health;
        if (health <= 0)
        {
            rb2D.velocity = new Vector2(0,0);
            //rb2D.gravityScale = 0.0f;
            GameController.isGameAlive = false;
            anim.SetTrigger("Dead");
            Invoke("KillPlayer",dieTime);
        }
        BlinkPlayer(blinks,seconds);
        polygonCollider2D.enabled = false;
        StartCoroutine(ShowPlayerHitBox());
    }
    IEnumerator ShowPlayerHitBox()
    {
        yield return new WaitForSeconds(hitBoxCDTime);
        polygonCollider2D.enabled = true;
    }
    public void KillPlayer()
    {
        Destroy(gameObject);
    }
    public void BlinkPlayer(int numBlinks, float seconds)
    {
        StartCoroutine(DoBlinks(numBlinks,seconds));
    }
    IEnumerator DoBlinks(int numBlinks, float seconds)
    {
        for(int i = 0;i < numBlinks*2; i++)
        {
            myRenderer.enabled = !myRenderer.enabled;
            yield return new WaitForSeconds(seconds);
        }
        myRenderer.enabled = true;
    }
}
