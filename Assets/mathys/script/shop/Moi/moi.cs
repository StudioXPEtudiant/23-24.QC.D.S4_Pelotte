using UnityEngine;
using UnityEngine.UI;

public class moi : MonoBehaviour
{
    [SerializeField] GameObject Achaa;
    //[SerializeField] Animator Panim;
    //[SerializeField] Animator Danim;
    [SerializeField] GameObject Panimm;
    [SerializeField] GameObject Danimm;
    [SerializeField] GameObject shopitem;
    public int CurrentCoins;
    public int coinsCount;
    public Text coinsCountText;
    public static moi instance;
    public int price;

    void Start()
    {
        Panimm.SetActive(true);
        Danimm.SetActive(false);
        CurrentCoins = coinsCount;
    }

    public void AchaS()
    {
        if(CurrentCoins >= price);
        {
            shopitem.SetActive (false);
            Achaa.SetActive (false);
            Debug.LogWarning ("Acheter");
            Panimm.SetActive(false);
            Danimm.SetActive(true);
            CurrentCoins -= price;
            //Panim.runtimeAnimatorController = Danim.runtimeAnimatorController;
        }
        else()
        {
            Debug.LogWarning("you can't");
        }
    }

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Debug.LogWarning("nn");
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        coinsCountText = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameOverManager>().coins;
    }

    public void AddCoins(int count)
    {
        CurrentCoins += count;
        coinsCount += count;
        coinsCountText.text = coinsCount.ToString();
    }
}
