using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMEnemyHealth : MonoBehaviour
{
    [SerializeField] private PlayerHealth health;
    [SerializeField] private Score score;
    private void Start()
    {

    }
    private void Update()
    {
        HealthEnemy enemy = FindAnyObjectByType<HealthEnemy>();
        enemy.onEnemyDeath += onEnemyDeath;
    }

    public void onEnemyDeath()
    {
        score.AddScore();
        if (health.curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
