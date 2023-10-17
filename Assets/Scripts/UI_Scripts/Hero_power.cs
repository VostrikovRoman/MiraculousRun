using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_power : MonoBehaviour
{
    public PlayerController hero;

    public Energy energyCount;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        int energy = energyCount.energyCount;
        string power = hero.Hero;
        if (energy == 3)
        {
            anim.SetBool("isOn", true);
        }
        else
        {
            anim.SetBool("isOn", false);
        }
        if (power == "ladybug")
        {
            anim.SetBool("isLadybug", true);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (power == "cat")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", true);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (power == "fox")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", true);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (power == "bee")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", true);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (power == "peacock")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", true);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isMouse", false);
        }
        else if (power == "rabbit")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isRabbit", true);
            anim.SetBool("isMouse", false);
        }
        else if (power == "mouse")
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
