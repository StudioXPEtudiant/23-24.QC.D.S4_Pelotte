using UnityEngine;
using UnityEngine.UI;

public class CharacterShopUI : MonoBehaviour
{ 
    [SerializeField] GameObject ShopPanel;
    [SerializeField] Transform shopMenu;
    [SerializeField] Transform ShopContainer;

    
    [SerializeField] Button openShopButton;
    [SerializeField] Button closeShopButton;
    [SerializeField] GameObject shopUI;


    void Start ()
    {
        AddShopEvents ();
    }

    void AddShopEvents()
    {
        openShopButton.onClick.RemoveAllListeners ();
        openShopButton.onClick.AddListener (OpenShop);

        closeShopButton.onClick.RemoveAllListeners ();
        closeShopButton.onClick.AddListener (CloseShop);
    }

    void OpenShop ()
    {
        shopUI.SetActive (true);
    }

    void CloseShop ()
    {
        shopUI.SetActive (false);
    }
}
