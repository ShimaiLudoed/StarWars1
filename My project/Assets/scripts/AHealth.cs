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

     

    private void Start()
    {
        curHealth = health;
        if (gameObject.CompareTag("Enemy")) ;
        {
           Score score = FindObjectOfType<Score>();
           PlayerHealth player = FindObjectOfType<PlayerHealth>();
        }
    }
    
    public virtual void GetDamage(int damage)
    {
        curHealth -= damage;
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
    
}
