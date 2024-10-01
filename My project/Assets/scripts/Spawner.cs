using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Win win;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnInterval = 3.0f; 
    [SerializeField] private int maxEnemies;

    private void Start()
    {
        maxEnemies=Random.Range(2, 7);
    }

    private float timer;
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }
    public void SpawnEnemy()
    {
        if (maxEnemies != 0)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            maxEnemies--;
        }
        else
        {
            Destroy(gameObject);
            
        }
    }
}
