using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    [field: SerializeField] public float Speed = 5f;
 
    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(move , 0,0);
        transform.position += movement * Speed * Time.deltaTime;
    }
}
