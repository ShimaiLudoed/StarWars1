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
    private const float rate1= .8f;
    private const float rate2 = 3f;


    private void Start()
    {
        FireRate = Random.Range(rate1,rate2);
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
