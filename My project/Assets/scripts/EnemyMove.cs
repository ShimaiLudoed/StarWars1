using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float MoveRate = 4f;
    [SerializeField] private float speed = 1f;
    private float curRate;

    private void Start()
    {
        curRate = MoveRate;
    }

    private void Update()
    {
        if (curRate <= 0)
        {
            curRate = MoveRate;
            Move();
        }
        else
        {
            curRate -= Time.deltaTime;
        }
    }

    private void Move()
    {
        Vector3 move = new Vector3(0, (float)-0.5, 0);
        transform.position += move * speed * MoveRate;

    }
}