using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchaMoi : MonoBehaviour
{
    [SerializeField] GameObject Acha;
    [SerializeField] Animator Panim;
    [SerializeField] Animator Danim;

    public void AchaS()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Acha.SetActive (false);
            Debug.LogWarning ("Acheter");
            Panim.runtimeAnimatorController = Danim.runtimeAnimatorController;
        }
    }
}
