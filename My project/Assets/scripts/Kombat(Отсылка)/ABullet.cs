using UnityEngine;

public abstract class ABullet : MonoBehaviour
{
    [SerializeField] protected int damageBull = 1;
    [SerializeField] protected internal float Speed = 10f;
}