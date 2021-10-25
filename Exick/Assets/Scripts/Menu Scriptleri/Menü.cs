using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menü : MonoBehaviour
{
    [Header("Ana Menu Sayfalari")]
    public GameObject ayarlarPenceresi;
    public GameObject creditsPenceresi;
    public GameObject anamenuPenceresi;
    public GameObject nasiloynanirpenceresi;

    public void OyunuBaslat()
    {
        SceneManager.LoadScene("Main");
    }
    public void MainDon()
    {
        SceneManager.LoadScene("Menu");
    }
    public void NasilOynanir()
    {
        anamenuPenceresi.SetActive(false);
        nasiloynanirpenceresi.SetActive(true);
    }
    public void Ayarlar()
    {
        anamenuPenceresi.SetActive(false);
        ayarlarPenceresi.SetActive(true);
    }
    public void gerigelAyar()
    {
        anamenuPenceresi.SetActive(true);
        ayarlarPenceresi.SetActive(false);
    }
    public void gerigelCredits()
    {
        anamenuPenceresi.SetActive(true);
        creditsPenceresi.SetActive(false);
    }

    public void gerigelHow()
    {
        anamenuPenceresi.SetActive(true);
        nasiloynanirpenceresi.SetActive(false);
    }
    public void Credits()
    {
        anamenuPenceresi.SetActive(false);
        creditsPenceresi.SetActive(true);
    }
    public void Cikis()
    {
        Application.Quit();
    }
}
