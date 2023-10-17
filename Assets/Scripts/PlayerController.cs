using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string Hero;
    public Health Alive;
    public GameController Move;

    public float jumpForce;

    private Rigidbody2D rb;

    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private bool Down;

    private Animator anim;

    public Energy energy;

    public DownMover Speed;


    public int num_skin;
    public GameController Skin;

    private void Start()
    {
        num_skin = Skin.num_skin;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }
    private void FixedUpdate()
    {
        num_skin = Skin.num_skin;
        Hero = Skin.skins[num_skin];
        if (Alive.alive == true && Move.move == true)
        {
            anim.SetBool("Stop", false);
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("Stop", true);
            anim.SetBool("isRunning", false);
        }


        if (Hero == "ladybug")
        {
            anim.SetBool("isLadybug", true);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (Hero == "cat")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", true);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (Hero == "fox")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", true);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (Hero == "bee")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", true);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (Hero == "peacock")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", true);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (Hero == "rabbit")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", true);
            anim.SetBool("isMouse", false);
        }
        else if (Hero == "mouse")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", true);
        }
    }

    private void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) && Alive.alive == true && Move.move == true)
        {
            Up();
        }
    }
    public void Up()
    {
        float speed = Speed.speed;
        if (isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce ;
        }
    }
    public void Exit()
    {
        Application.Quit();
    }

    

}
