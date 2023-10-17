using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawnerController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Despawner")
        {
            Destroy(gameObject);
        }
    }

}
