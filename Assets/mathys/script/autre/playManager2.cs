using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayManager2 : MonoBehaviour
{
    public void mainmenuquit(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
