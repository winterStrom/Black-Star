using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Text healthText;
    public static int healthCurrent;
    public static int healthMax;
    private Image healthBar;
    void Start()
    {
        healthBar = GetComponent<Image>();
        //healthCurrent = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)healthCurrent / (float)healthMax;
        healthText.text = healthCurrent.ToString() + "/" + healthMax.ToString();
    }
}
