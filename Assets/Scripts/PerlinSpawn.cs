using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinSpawn : MonoBehaviour
{
    public Vector2 gridSize = new Vector2(16f, 16f);
    public GameObject cubePrefab;
    public float perlinScale = 0.1f;
    public float heightMultiplier = 10f;
    
    private void Start()
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                float perlin = Mathf.PerlinNoise(x * perlinScale, y * perlinScale) * heightMultiplier;
                perlin = Mathf.RoundToInt(perlin);
                Vector3 spawnPosition = new Vector3(x, perlin, y);
                Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
            }
        }    
    }
}
