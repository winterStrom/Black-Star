using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isDoor;
    private PlayerInputActions controls;

     void Awake()
    {
         controls = new PlayerInputActions();

         controls.GamePlayer.DoorToNextLevel.started += ctx =>EnterNextLevel();
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnterNextLevel()
    {
        if(isDoor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")
            && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            isDoor = true;
        }
    }
}
