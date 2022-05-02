using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialogBox;
    public Text  dialogBoxText;
    public string signText;
    private bool isPlayerInSign;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)&& isPlayerInSign)
        {
            dialogBoxText.text = signText;
            dialogBox.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {  
        if(other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            isPlayerInSign = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) 
    {
         if(other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            
            isPlayerInSign = false;
            dialogBox.SetActive(false);
        }
    }
}
