using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] GameObject GameOvermenu;

    public void Close()
    {
        GameOvermenu.SetActive(false);
    }
    
}
