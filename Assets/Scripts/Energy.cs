using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public int energyCount;

    private void Start()
    {
        energyCount = 0;
    }
    public void Use_Power()
    {
        if (energyCount == 3)
        {
            energyCount = 0;
        }
    }
    public void Energy_plus()
    {
        if (energyCount < 3)
        {
            energyCount += 1;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Energy")
        {
            Energy_plus();
        }
    }
    public void GameAgain()
    {
        energyCount = 0;
    }
    
}
