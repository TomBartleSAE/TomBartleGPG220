using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberToSpawn = 1;
    public Vector2 locationRange = new Vector2(25f, 25f);
    
    private void Awake()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            Instantiate(objectToSpawn,
                new Vector3(Random.Range(-locationRange.x, locationRange.x), transform.position.y, Random.Range(-locationRange.y,
                    locationRange.y)), Quaternion.identity);
        }
    }
}
