using UnityEngine;

public class ShootSys : AShootSys
{
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}