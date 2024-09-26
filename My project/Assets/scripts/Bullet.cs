using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int damageBull=1;
    [SerializeField] public float Speed = 10f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth player))
        {
            player.GetDamage(damageBull);
            Destroy(gameObject);
        }
        if (collision.gameObject.TryGetComponent(out HealthEnemy enemy ))
        {
            enemy.GetDamage(damageBull);
            Destroy(gameObject);
        }
       
        if (collision.gameObject.CompareTag("obtacle")) 
        {
            Destroy(gameObject);
        }
    }
}
