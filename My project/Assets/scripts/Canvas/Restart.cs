using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restartgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}