using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AHealth : MonoBehaviour
{
    [SerializeField] private int health;
     public int curHealth;
     public Score score;
     

    private void Start()
    {
        curHealth = health;
        if (gameObject.CompareTag("Enemy")) ;
        {
            score = FindObjectOfType<Score>();
        }
    }
    
    public void GetDamage(int damage)
    {
        curHealth -= damage;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
    
}
