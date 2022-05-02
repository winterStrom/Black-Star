using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrelCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public Text coinText;
    public static int coinCurrent;
    public static int coinMax;

    private Image barrelBar;
    void Start()
    {
        barrelBar = GetComponent<Image>();
        coinCurrent = 0;
        coinMax = 99;

    }

    // Update is called once per frame
    void Update()
    {
        barrelBar.fillAmount = (float)coinCurrent/(float)coinMax;
        coinText.text = coinCurrent.ToString()+"/"+coinMax.ToString();
    }
}
