using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMoi : MonoBehaviour
{
    [SerializeField] GameObject ShopUI;

    public void CloseShop()
    {
        ShopUI.SetActive (false);
    }

    public void OpenShop()
    {
        ShopUI.SetActive (true);
    }
}
