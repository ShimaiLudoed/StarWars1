using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ShootSys : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private Transform FirePoint;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && gameObject.CompareTag("Player"))
        {
            Shoot();
        }

    }


    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPref, FirePoint.position, FirePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = (FirePoint.up * bullet.GetComponent<ABullet>().Speed);

    }
}