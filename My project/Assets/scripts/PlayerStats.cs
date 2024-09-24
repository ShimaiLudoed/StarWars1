using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Health
{

    private int Health = 3;
    
    public void GetDamage(int damage)
    {
        Health -= damage;
    }
}
