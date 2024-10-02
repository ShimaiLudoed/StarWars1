using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private const float rate1 = .8f;
    private const float rate2 = 3f;

    [SerializeField] private float FireRate;
    [SerializeField] public ShootSys shootsys;
    private float curtime;


    private void Start()
    {
        FireRate = Random.Range(rate1, rate2);
        curtime = FireRate;
    }

    private void Update()
    {
        if (curtime <= 0)
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