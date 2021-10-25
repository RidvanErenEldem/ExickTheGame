using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuniciMenu : MonoBehaviour
{
    
    public GameObject DuraklatMenu;
    public static bool  Durdumu = false;
    public void  Devamet()
    {
        DuraklatMenu.SetActive(false);
        Time.timeScale = 1f;
        Durdumu = false;
       
    }
    void Durdur()
    {
        
        DuraklatMenu.SetActive(true);
        Time.timeScale = 0f;
        Durdumu = true;
        
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OyunuKapat()
    {
        Application.Quit();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (Durdumu)
            {
                Devamet();
                
            }
            else
            {

                Durdur();
            }
        }
    }
}
