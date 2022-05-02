using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
   public int damage;
    public int health;
    public float flashTime;
    public GameObject bloodEffect;
    public GameObject dropCoin;
    public GameObject floatPoint;
    private SpriteRenderer sprite;
    private Color originalColor;
    private PlayerHealth playerHealth;
    public void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        sprite = GetComponent<SpriteRenderer>();
        originalColor = sprite.color;       
    }

    // Update is called once per frame
    public void Update()
    {
        if (health <= 0)
        {
            Instantiate(dropCoin,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        GameObject gb = Instantiate(floatPoint,transform.position,Quaternion.identity) as GameObject;
        gb.transform.GetChild(0).GetComponent<TextMesh>().text = damage.ToString();
        health -= damage;
        FlashColor(flashTime);
        Instantiate(bloodEffect,transform.position,Quaternion.identity);
        GameController.camShake.Shake();
    }
    public void FlashColor(float time)
    {
        sprite.color = Color.red;
        Invoke("ResetColor",time);
    }
    public void ResetColor()
    {
        sprite.color = originalColor;
    }
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            if (playerHealth != null)
            {
                playerHealth.DamagePlayer(damage);
            }
        }
    }
}
