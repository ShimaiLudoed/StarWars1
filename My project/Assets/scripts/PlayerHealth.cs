using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class PlayerHealth : AHealth
{
    public GameObject DeathMenu;
    public GameObject GameMenu;
    public TextMeshProUGUI Dscore;
    private void Update()
    {
        if (curHealth <= 0)
        {
            GameMenu.SetActive(false);
            Die();
            DeathMenu.SetActive(true);
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        Dscore.text = "Ваш счёт"+" "+ score.score;
    }
}
