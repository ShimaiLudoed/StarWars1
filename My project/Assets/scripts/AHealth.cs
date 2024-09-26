using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public abstract class AHealth : MonoBehaviour
{
    [SerializeField] private int health;
     public int curHealth;

    private void Start()
    {
        curHealth = health;
    }

    public void GetDamage(int damage)
    {
        curHealth -= damage;
    }
}
