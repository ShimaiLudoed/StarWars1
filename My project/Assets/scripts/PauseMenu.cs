using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pause;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            gameObject.SetActive(false);
            Pause.SetActive(true);
        }
    }
}
