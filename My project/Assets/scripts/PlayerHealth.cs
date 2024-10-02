using System;

public class PlayerHealth : AHealth
{
    public event Action onPlayerDeath;

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