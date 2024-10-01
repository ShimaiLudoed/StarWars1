using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinMen;

    void Update()
    {
        GameObject[] spawner = GameObject.FindGameObjectsWithTag("Spawn");
        if (spawner.Length==0)
        {
            WinMen.SetActive(true);
        }
        
    }
}
