using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public PlayerStats player;

    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(move, 0f);
        transform.position = movement * player.Speed * Time.deltaTime;
    }
}
