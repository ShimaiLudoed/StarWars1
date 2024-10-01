using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthEnemy : AHealth
{
    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
        if (curHealth <= 0)
        {
            Die();
        }
    }
    
    private void Update()
    {
        if (curHealth <= 0)
        {
            Die();
        }

        if (player.curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public override void Die()
    {
        base.Die();
        score.AddScore();
    }
}