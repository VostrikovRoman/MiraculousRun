using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_head : MonoBehaviour
{
    public PlayerController hero;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        string head = hero.Hero;
        if (head == "ladybug")
        {
            anim.SetBool("isLadybug", true);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (head == "cat")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", true);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (head == "fox")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", true);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (head == "bee")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", true);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (head == "peacock")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", true);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (head == "rabbit")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", true);
            anim.SetBool("isMouse", false);
        }
        else if (head == "mouse")
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
}
