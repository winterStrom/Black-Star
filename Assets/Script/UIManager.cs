using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform UI_Element;
    public RectTransform CanvasRect;
    public Transform transBarrel;
    public float xOffest;
    public float yOffest;
    public Text coinNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 viewPortPos = Camera.main.WorldToViewportPoint(transBarrel.position);
        Vector2 worldObjectScreenPos = new Vector2((viewPortPos.x*CanvasRect.sizeDelta.x) - (CanvasRect.sizeDelta.x * 0.5f)+xOffest,
        (viewPortPos.y*CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f)+yOffest);
        UI_Element.anchoredPosition = worldObjectScreenPos;
    }
}
