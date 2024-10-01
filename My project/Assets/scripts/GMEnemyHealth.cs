using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GMEnemyHealth : MonoBehaviour
{
    public Score score;
    void Start()
    {
        HealthEnemy enemyhealth = FindObjectOfType<HealthEnemy>();

        if (enemyhealth != null)
        {
            enemyhealth.onEnemyDeath += HandleEnemyDeath;
        }
    }

    void HandleEnemyDeath()
    {
        score.AddScore();
        Debug.Log("Game Over");
    }
}
