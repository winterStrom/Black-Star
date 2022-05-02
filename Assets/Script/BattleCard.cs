using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateIMagic(GameObject gameObject,Transform none)
    {
        Instantiate(gameObject,none.position,none.rotation); 
    }
}
