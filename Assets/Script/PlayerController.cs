using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float runSpeed;

    [SerializeField]
    private float jumpSpeed;

    [SerializeField]
    private float doubleJumpSpeed;
    public GameObject myBag;
    private bool isOpen;
    public float restoreTime;
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    private BoxCollider2D myFeet;
    private bool isGround;
    private bool canDoubleJump;
    private bool isOneWayPlatform;
    private PlayerInputActions controls;

    private Vector2 move;
    void Awake() 
    {
        controls = new PlayerInputActions();
        controls.GamePlayer.Move.performed += ctx => move = ctx.ReadValue<Vector2>();    
        controls.GamePlayer.Move.canceled += ctx => move = Vector2.zero;
        controls.GamePlayer.Jump.started += ctx => Jump(); 
        controls.GamePlayer.OpenBag.started += ctx =>OpenMyBag(); 
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
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myFeet = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.isGameAlive)
        {
        Filp();
        Run();
        //Jump();
        //Attack();
        CheckGround();
        SwitchAnimation();
        OneWayPlatformCheck();
        }
    }
    private void CheckGround()
    {
        isGround = myFeet.IsTouchingLayers(LayerMask.GetMask("Ground"))||
        myFeet.IsTouchingLayers(LayerMask.GetMask("MovingPlatform"))||
        myFeet.IsTouchingLayers(LayerMask.GetMask("OneWayPlatform"));
        isOneWayPlatform =  myFeet.IsTouchingLayers(LayerMask.GetMask("OneWayPlatform"));
    }
    private void Filp()
    {
        bool playerHasXAxisSpeed = Mathf.Abs(myRigidbody2D.velocity.x) > Mathf.Epsilon; 
        if (playerHasXAxisSpeed)
        {
            if(myRigidbody2D.velocity.x > 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0,0,0);
            }
            if(myRigidbody2D.velocity.x < -0.1f)
            {
                transform.localRotation = Quaternion.Euler(0,180,0);
            }
        }
    }
    private void Run()
    {
        // float moveDir = Input.GetAxis("Horizontal");
        // Vector2 playerVel = new Vector2(moveDir * runSpeed ,myRigidbody2D.velocity.y);
        // myRigidbody2D.velocity = playerVel;
        // bool playerHasXAxisSpeed = Mathf.Abs(myRigidbody2D.velocity.x) > Mathf.Epsilon; 
        // myAnimator.SetBool("Run",playerHasXAxisSpeed);
        Vector2 playerVel = new Vector2(move.x * runSpeed ,myRigidbody2D.velocity.y);
        myRigidbody2D.velocity = playerVel;
        bool playerHasXAxisSpeed = Mathf.Abs(myRigidbody2D.velocity.x) > Mathf.Epsilon; 
        myAnimator.SetBool("Run",playerHasXAxisSpeed);
    }
    void OpenMyBag()
    {
        isOpen = !isOpen;
        myBag.SetActive(isOpen);
    }
    private void Jump()
    {
        //if (Input.GetButtonDown("Jump"))
        {
            if (isGround)
            {
            myAnimator.SetBool("Jump",true);    
            Vector2 jumpVel = new Vector2(0.0f,jumpSpeed);
            myRigidbody2D.velocity = Vector2.up * jumpVel;   
            canDoubleJump = true;
            } 
            else
            {
                if(canDoubleJump)
                {
                    myAnimator.SetBool("DoubleJump",true);   
                    Vector2 doubleJumpVel = new Vector2(0.0f,doubleJumpSpeed);
                    myRigidbody2D.velocity = Vector2.up * doubleJumpVel;
                    canDoubleJump = false;
                }
            }
        }
    }

    // private void Attack()
    // {
    //     if (Input.GetButtonDown("Attack"))
    //     {
    //         if (!myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
    //         {
    //             myAnimator.SetTrigger("Attack");
    //             //StartCoroutine(EableHitBox());
    //         }
    //     }
    // }
    private void SwitchAnimation()
    {
        myAnimator.SetBool("Idle",false);
        if (myAnimator.GetBool("Jump"))
        {
            if(myRigidbody2D.velocity.y < 0.0f)
            {
                myAnimator.SetBool("Jump",false);
                myAnimator.SetBool("Fall",true);
            }
        }
        else if(isGround)
        {
            myAnimator.SetBool("Fall",false);
            myAnimator.SetBool("Idle",true);
        }
        if (myAnimator.GetBool("DoubleJump"))
        {
            if(myRigidbody2D.velocity.y < 0.0f)
            {
                myAnimator.SetBool("DoubleJump",false);
                myAnimator.SetBool("DoubleFall",true);
            }
        }
        else if(isGround)
        {
            myAnimator.SetBool("DoubleFall",false);
            myAnimator.SetBool("Idle",true);
        }
    }
    public void OneWayPlatformCheck()
    {
        if(isGround && gameObject.layer != LayerMask.NameToLayer("Player"))
        {
            gameObject.layer = LayerMask.NameToLayer("Player");
        }
        float moveY = Input.GetAxis("Vertical");
        if(isOneWayPlatform && moveY < -0.1f)
        {
            gameObject.layer = LayerMask.NameToLayer("OneWayPlatform");
            Invoke("ResetPlayerLayer",restoreTime);
        }
    }
    public void ResetPlayerLayer()
    {
        if(!isGround && gameObject.layer != LayerMask.NameToLayer("Player"))
        {
            gameObject.layer = LayerMask.NameToLayer("Player");
        }
    }
}