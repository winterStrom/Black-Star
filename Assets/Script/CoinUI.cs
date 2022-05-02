using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    // Start is called before the first frame update
    public int startCoinQuantity;
    public Text coinNumber;
    public static int CurrentCoinQuantity;
    void Start()
    {
        CurrentCoinQuantity = startCoinQuantity;
    }

    // Update is called once per frame
    void Update()
    {
        coinNumber.text = CurrentCoinQuantity.ToString();
    }
}
