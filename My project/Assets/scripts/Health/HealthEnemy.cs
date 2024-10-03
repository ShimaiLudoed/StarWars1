using UnityEngine;

public class HealthEnemy : AHealth
{
    private PlayerHealth player;

    private void Start()
    {
        curHealth = health;
        score = FindObjectOfType<Score>();
        player = FindAnyObjectByType<PlayerHealth>();
    }
    private void Update()
    {
        if (curHealth <= 0)
        {
            Die();
        }

        if (player.curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
        if (curHealth <= 0)
        {
            Die();
        }
    }

    public override void Die()
    {
        base.Die();
        score.AddScore();
    }
}