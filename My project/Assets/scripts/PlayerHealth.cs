using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PlayerHealth : AHealth
{
    public event Action onPlayerDeath;

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
        onPlayerDeath?.Invoke();
        base.Die();
    }
}