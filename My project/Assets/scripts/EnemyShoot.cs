using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyShoot : MonoBehaviour
{

    [SerializeField] private float FireRate ;
    [SerializeField] public ShootSys shootsys;
    private float curtime;

    private void Start()
    {
        FireRate = Random.Range(0.8f, 3.0f);
        curtime = FireRate;
    }
    private void Update()
    {
       if(curtime<=0)
        {
            curtime = FireRate;
            shootsys.Shoot();
        }
       else
        {
            curtime -= Time.deltaTime;
        }
    }

}
