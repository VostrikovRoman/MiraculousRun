using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Health Alive;
    public GameController Move;
    public string Enemy;

    private Rigidbody2D rb;


    private Animator anim;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
        Enemy = "bubbler";
    }
    private void FixedUpdate()
    {
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



        if (Enemy == "bubbler")
        {
            anim.SetBool("isBubbler", true);
            anim.SetBool("isLadyWiFi", false);
            anim.SetBool("isGamer", false);
            anim.SetBool("isStyleQueen", false);
        }
        else if (Enemy == "ladyWiFi")
        {
            anim.SetBool("isBubbler", false);
            anim.SetBool("isLadyWiFi", true);
            anim.SetBool("isGamer", false);
            anim.SetBool("isStyleQueen", false);
        }
        else if (Enemy == "gamer")
        {
            anim.SetBool("isBubbler", false);
            anim.SetBool("isLadyWiFi", false);
            anim.SetBool("isGamer", true);
            anim.SetBool("isStyleQueen", false);
        }
        else if (Enemy == "style_queen")
        {
            anim.SetBool("isBubbler", false);
            anim.SetBool("isLadyWiFi", false);
            anim.SetBool("isGamer", false);
            anim.SetBool("isStyleQueen", true);
        }

    }
    

}
