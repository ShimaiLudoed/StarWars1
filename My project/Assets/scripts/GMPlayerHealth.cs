using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GMPlayerHealth : MonoBehaviour
{
    public Score score;
    public GameObject DeathMenu;
    public GameObject GameMenu;
    public TextMeshProUGUI Dscore;
    void Start()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.onPlayerDeath += HandlePlayerDeath;
        }
    }

    void HandlePlayerDeath()
    {
        Debug.Log("Game Over");
        GameMenu.SetActive(false);
        DeathMenu.SetActive(true);
        UpdateScore();
    }

    void UpdateScore()
    {
        Dscore.text = $"¬аш счЄт {score.score})";
    }
}

