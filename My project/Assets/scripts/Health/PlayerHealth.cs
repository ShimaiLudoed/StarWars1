using System;

public class PlayerHealth : AHealth
{
    public event Action onPlayerDeath;

    private void Start()
    {
        curHealth = health;
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
        onPlayerDeath?.Invoke();
        base.Die();
    }
}