using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Gorev gorev;
    private bool isTriggered = false;


    void OnTriggerEnter2D()
    {
        if(isTriggered)
            return;

        Dialog.dialog.yazbabus(gorev.Diyalog);
        GorevlerScript.gorevlerScript.GorevEkle(gorev);
        this.gameObject.SetActive(false);
        isTriggered = true;
    }
}
