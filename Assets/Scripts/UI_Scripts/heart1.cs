using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart1 : MonoBehaviour
{
    private Animator anim;
    public Health HealthCount;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        int health = HealthCount.healthCount;
        if (health > 0)
        {
            anim.SetBool("heartOn", true);
        }
        else
        {
            anim.SetBool("heartOn", false);
        }

    }
}
