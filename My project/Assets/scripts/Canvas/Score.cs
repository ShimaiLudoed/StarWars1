using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI Tscore;
    public int score;

    private void Start()
    {
        score = 0;
        Tscore.text = "Score" + " " + score;
    }

    public void AddScore()
    {
        score += 10;
        Tscore.text = "Score" + " " + score;
    }
}