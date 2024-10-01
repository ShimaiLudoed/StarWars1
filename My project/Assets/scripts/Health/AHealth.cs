using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public abstract class AHealth : MonoBehaviour
{
    [SerializeField] private int health;
     protected int curHealth;
     protected Score score;
     protected PlayerHealth player;
     
    public event Action onEnemyDeath;


    private void Start()
    {
        curHealth = health;
        if (gameObject.CompareTag("Enemy")) //поменять
        {
            score = FindObjectOfType<Score>();
            player = FindObjectOfType<PlayerHealth>();
        }
    }

    public void Die()
    {
       
        if(gameObject.CompareTag("Enemy"))
        {
            onEnemyDeath?.Invoke();
        }
        Destroy(gameObject);
    }
}
