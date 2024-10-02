using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject Pause;

    private void Start() { }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            gameObject.SetActive(false);
            Pause.SetActive(true);
        }
    }
}