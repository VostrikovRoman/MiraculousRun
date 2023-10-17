using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMover : MonoBehaviour
{
    public float speed;
    private RoadSpawnerController spawner;
    private bool spawned;
    public Health Alive;
    public GameController Move;

    private void Start()
    {
        spawner.SpawnWave();
        spawner = FindObjectOfType<RoadSpawnerController>();
        speed = spawner.speed;
    }

    private void FixedUpdate()
    {
        if (Alive.alive == true && Move.move == true)
        {
            Go();
        }
        
    }
    private void Go()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        speed += spawner.speedIncrease * Time.deltaTime;
    }
}
