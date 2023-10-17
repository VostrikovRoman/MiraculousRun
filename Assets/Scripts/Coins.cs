using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int coins;
    public Text Count;

    private void FixedUpdate()
    {
        Count.text = ""+coins;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            coins += 1;
        }
    }
}
