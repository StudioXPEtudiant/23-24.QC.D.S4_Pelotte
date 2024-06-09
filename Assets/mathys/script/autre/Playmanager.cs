using UnityEngine;
using UnityEngine.SceneManagement;

public class Playmanager : MonoBehaviour
{
    public GameObject gameOverUI;

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);

    }
}