using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinMen;

    private void Update()
    {
        GameObject[] spawner = GameObject.FindGameObjectsWithTag("Spawn");
        if (spawner.Length == 0)
        {
            WinMen.SetActive(true);
        }

    }
}