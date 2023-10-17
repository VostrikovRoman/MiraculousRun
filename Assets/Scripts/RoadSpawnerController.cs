using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawnerController : MonoBehaviour
{
    public GameObject[] roads;

    public float speed;
    public float speedIncrease;
    public Health Alive;
    public GameController Move;

    private void Start()
    {
        //if (Alive.alive == true && Move.move == true)
        //{
        //    InvokeRepeating("SpawnWave", 1, 1);
        //}
        speed = 0.6f;
        speedIncrease = 0.001f;
    }
    private void Update()
    {
        if (Alive.alive == true && Move.move == true)
        {
            speed += speedIncrease * Time.deltaTime;
        }
        else
        {
            speed = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RoadTrigger" && Alive.alive == true && Move.move == true)
        {
            SpawnWave();
        }
    }
    

    public void SpawnWave()
    {
        int rand = Random.Range(0, roads.Length);
        GameObject cloneRoad = Instantiate(roads[0], new Vector2(2.57f, 0.037f), Quaternion.identity);
        //if (Alive.alive == true && Move.move == true)
        //{
        //    Destroy(cloneRoad, 10);
        //}
            
    }
}
