using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    
    public TextMeshProUGUI Tscore;
    public int score;

    private void Start()
    {
        score = 0;
        Tscore.text = "Score"+" "+ score;
    }

    public void AddScore()
    {
        score += 10;
        Tscore.text = "Score"+" "+ score;
    }


    
}
