using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GorevEkrandaGoster : MonoBehaviour
{
    public TMP_Text aciklama;
    public Image itemResmi;
    public GameObject ekran;
    public void Guncelle(Gorev gorev)
    {
        ekran.SetActive(true);
        aciklama.text = gorev.GorevAciklama;
        itemResmi.sprite = gorev.item.Resim;
    }
}
