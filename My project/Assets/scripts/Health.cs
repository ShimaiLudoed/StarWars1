using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [SerializeField] private int health;

         public void GetDamage(int damage)
    {
        health -= damage;
    }
}
