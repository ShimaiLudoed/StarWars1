using UnityEngine;

public abstract class AHealth : MonoBehaviour
{
    [SerializeField] protected int health;
    public int curHealth;
   
    protected Score score;

    public virtual void GetDamage(int damage)
    {
        curHealth -= damage;
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}