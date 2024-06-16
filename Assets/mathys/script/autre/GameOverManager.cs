using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject Shop;
    public GameObject gameOverUI;
    public static GameOverManager instance;
    //public PlayerHealth playervie;
    public string mainMenu;
    public Text coins;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("mange tes mort");
            return;
        }

        instance = this;
    }

    public void OnPlayerDeath()
    {
        gameOverUI.SetActive(true);
    }


    public void RetryButton()
    {
        gameOverUI.SetActive(false);
    }

    public void MainMenuButton()
    {
        Shop.SetActive (true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
