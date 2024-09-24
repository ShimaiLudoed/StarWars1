using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    SerializeField[] private int damageBull;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerStats player))
        {
            player.GetDamage(damageBull);
        }
        if (collision.gameObject.TryGetComponent(out HealthEnemy enemy ))
        {
            
        }
    }
}
