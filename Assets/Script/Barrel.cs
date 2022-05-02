using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPlayerInBarrel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            if(isPlayerInBarrel)
            {
                if(CoinUI.CurrentCoinQuantity > 0)
                {
                    SoundManager.PlayThrowCoinClip();
                    BarrelCoin.coinCurrent++;
                    CoinUI.CurrentCoinQuantity--;
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {  
        if(other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            isPlayerInBarrel = true;
            Debug.Log("Player is In TrashBin");
        }
    }
    void OnTriggerExit2D(Collider2D other) 
    {
         if(other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            
            isPlayerInBarrel = false;
            Debug.Log("Player is In TrashBin");
            
        }
    }
}
