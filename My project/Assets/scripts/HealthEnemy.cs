using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthEnemy : AHealth
{
    
    private void Update()
    {
        if (curHealth <= 0)
        {
            Die();
            score.AddScore();
        }

        if (player.curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
