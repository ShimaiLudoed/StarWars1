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
    private const int num1= 2;
    private const int num2 = 7;


    //TODO сделать private и магические числа убрать 
    private void Start()
    {
        maxEnemies=Random.Range(num1, num2);
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
