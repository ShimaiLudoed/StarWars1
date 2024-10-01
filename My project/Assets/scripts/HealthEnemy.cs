using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthEnemy : AHealth
{
    public event Action onEnemyDeath;

    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
        if (curHealth <= 0)
        {
            Die();
        }
    }
    public override void Die()
    {
        onEnemyDeath?.Invoke();
        base.Die();
    }

}
