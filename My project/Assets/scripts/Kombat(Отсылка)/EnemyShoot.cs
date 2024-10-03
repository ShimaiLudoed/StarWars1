using UnityEngine;

public class EnemyShoot : AShootSys
{
    private const float MinRate = .8f;
    private const float Maxrate = 3f;
    [SerializeField] private float FireRate;
    private float curtime;


    private void Start()
    {
        FireRate = Random.Range(MinRate,Maxrate);
        curtime = FireRate;
    }

    private void Update()
    {
        if (curtime <= 0)
        {
            curtime = FireRate;
            Shoot();
        }
        else
        {
            curtime -= Time.deltaTime;
        }
    }
}