using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : ABullet
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out HealthEnemy enemy))
        {
            enemy.GetDamage(damageBull);
            Destroy(gameObject);
        }
        
    }
}
