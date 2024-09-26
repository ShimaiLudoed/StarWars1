using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    [SerializeField] private float FireRate = 1.5f;
    [SerializeField] public ShootSys shootsys;
    private float curtime;

    private void Start()
    {
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
