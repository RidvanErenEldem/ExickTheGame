using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public TMP_Text ekranText;
    public int time = 5;
    public static Dialog dialog; //static : başka script aranmadan bulunsun diye.

    void Start()
    {
        dialog = this;
        gameObject.SetActive(false);
    }




    public void yazbabus(string yazilacak)
    {
        ekranText.text = yazilacak;
        this.gameObject.SetActive(true);
        StartCoroutine(TestCor());
    }

    IEnumerator TestCor()
    {
        

        yield return new WaitForSeconds(time);

        this.gameObject.SetActive(false);

    }

    
    

}
