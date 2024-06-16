using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchaMoi : MonoBehaviour
{
    [SerializeField] GameObject Acha;
    //[SerializeField] Animator Panim;
    //[SerializeField] Animator Danim;
    [SerializeField] GameObject Panimm;
    [SerializeField] GameObject Danimm;
    [SerializeField] GameObject shopitem;

    void Start()
    {
        Panimm.SetActive(true);
        Danimm.SetActive(false);
    }

    public void AchaS()
    {
        shopitem.SetActive (false);
        Acha.SetActive (false);
        Debug.LogWarning ("Acheter");
        Panimm.SetActive(false);
        Danimm.SetActive(true);
        //Panim.runtimeAnimatorController = Danim.runtimeAnimatorController;
    }
}