using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text coinsText;
    public int coins = 100;

    // Définir la classe pour un article dans le magasin
    [System.Serializable]
    public class ShopItem
    {
        public string itemName;
        public int price;
    }

    public ShopItem[] items;

    void Start()
    {
        UpdateCoinsText();
    }

    // Fonction pour acheter un article
    public void BuyItem(int itemIndex)
    {
        if (coins >= items[itemIndex].price)
        {
            coins -= items[itemIndex].price;
            UpdateCoinsText();
            Debug.Log("Vous avez acheté " + items[itemIndex].itemName);
        }
        else
        {
            Debug.Log("Fonds insuffisants pour acheter " + items[itemIndex].itemName);
        }
    }

    // Fonction pour vendre un article
    public void SellItem(int itemIndex)
    {
        coins += items[itemIndex].price;
        UpdateCoinsText();
        Debug.Log("Vous avez vendu " + items[itemIndex].itemName);
    }

    // Mettre à jour le texte des pièces
    void UpdateCoinsText()
    {
        coinsText.text = "Pièces: " + coins.ToString();
    }
}
