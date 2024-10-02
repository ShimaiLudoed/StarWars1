using UnityEngine;

public abstract class AHealth : MonoBehaviour
{
    [SerializeField] private int health;
    public int curHealth;
    [SerializeField] protected PlayerHealth player;
    protected Score score;

    private void Start()
    {
        curHealth = health;
        if (gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            score = FindObjectOfType<Score>();
            player = FindObjectOfType<PlayerHealth>();
        }
    }

    public virtual void GetDamage(int damage)
    {
        curHealth -= damage;
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}