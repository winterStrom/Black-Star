using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject img1;
    public GameObject img2;
    public float time;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            animator.SetBool("ChangeToWhite",true);
            Invoke("ChangeImage",time);
        }
    }
    void ChangeImage()
    {
        img1.SetActive(false);
        img2.SetActive(true);
    }
}
