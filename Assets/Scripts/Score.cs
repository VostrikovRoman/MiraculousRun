using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text Count;
    public GameController Move;
    public Health Alive;

    private void FixedUpdate()
    {
        if (Move.move == true && Alive.alive == true)
        {
            score += 1;
            Count.text = "" + score;
        }
    }
}
