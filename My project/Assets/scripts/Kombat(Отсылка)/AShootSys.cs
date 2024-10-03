using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AShootSys : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private Transform FirePoint;
    
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPref, FirePoint.position, FirePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = FirePoint.up * bullet.GetComponent<ABullet>().Speed;
    }
}
