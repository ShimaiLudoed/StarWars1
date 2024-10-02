using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [field: SerializeField] public float Speed = 5f;


    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(move, 0, 0);
        transform.position += movement * Speed * Time.deltaTime;
    }
}