using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinMen;
    public GameObject[] spawner;

    private void Start()
    {
        spawner = GameObject.FindGameObjectsWithTag("Spawn");
    }

    void Update()
    {
        if (spawner == null)
        {
            WinMen.SetActive(true);
            spawner = GameObject.FindGameObjectsWithTag("Spawn");
        }
    }
}
