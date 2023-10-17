using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public GameObject gameOver;
    public int healthCount;
    public bool alive = true;

    private void Start()
    {
        healthCount = 3;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Barrier")
        {
            Health_minus();
        }
    }
    private void Update()
    {
        if (healthCount == 0)
        {
            GameOver();
        }
    }


    private void Health_minus()
    {
        if (healthCount > 0)
        {
            healthCount -= 1;
        }
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        alive = false;
    }
    public void GameAgain()
    {
        gameOver.SetActive(false);
        healthCount = 3;
        alive = true;
    }
}
