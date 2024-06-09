using UnityEngine;
using UnityEngine.UI;

public class Acha : MonoBehaviour
{
    [SerializeField] GameObject ButtonBuy;
    private bool nomBooleen = true;

    public void Buy()
    {
        if(nomBooleen == true)
        {
            Debug.LogWarning("gg");
        }
    }
}
