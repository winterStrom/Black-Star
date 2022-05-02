using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] monsterPrefabs;
    public int monsterNum;
    public List<Enemy> enemies = new List<Enemy>();
    //public Transform[] link;
    private Transform playerTran;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerTran = player.transform;
        for(int i = 0; i < monsterNum ; i++)
        {
            enemies.Add(Instantiate(monsterPrefabs[Random.Range(0,monsterPrefabs.Length)],transform.position,Quaternion.identity).GetComponentInChildren<Enemy>());
        }
        for(int i = 0; i < monsterNum ; i++)
        {
            enemies[i].GetComponentInChildren<EnemySmartBat>().playerTransform = playerTran;
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
