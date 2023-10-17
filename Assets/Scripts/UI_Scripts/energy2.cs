using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energy2 : MonoBehaviour
{
    private Animator anim;
    public Energy EnergyCount;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        int energy = EnergyCount.energyCount;
        if (energy > 1)
        {
            anim.SetBool("energyOn", true);
        }
        else
        {
            anim.SetBool("energyOn", false);
        }

    }
}
