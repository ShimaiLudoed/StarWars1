using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GMHealth : MonoBehaviour
{
    [SerializeField] private GameObject DeathMenu;
    [SerializeField] private GameObject GameMenu;
    [SerializeField] private TextMeshProUGUI Dscore;
    [SerializeField] private Score score;

    private void Start()
    {
        PlayerHealth player = FindAnyObjectByType<PlayerHealth>();
        player.onPlayerDeath += onPlayerDeath;
    }

    private void onPlayerDeath()
    {
        GameMenu.SetActive(false);
        DeathMenu.SetActive(true);
        UpdateScore();
    }

    void UpdateScore()
    {
        Dscore.text = ($"��� ���� {score.score}");
    }
}