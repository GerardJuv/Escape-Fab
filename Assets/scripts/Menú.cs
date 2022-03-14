using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Menú : MonoBehaviour {

    public Canvas Menu;
    public Canvas HowTo;
    public Canvas Credits;
    public Canvas Options;


   
    public void BacktoMenu()
    {
        SceneManager.LoadScene("0-Menu");
    }

    // Empezar a jugar
    public void Playgame()
    {

      //  Advertisement.Show(); ???
        SceneManager.LoadScene("1-LevelSelect");
    }

    // Instrucciones 
    public void Tutorial()
    {
       
        Menu.gameObject.SetActive(false);
        HowTo.gameObject.SetActive(true);
    }
     public void Opciones()
    {
        Menu.gameObject.SetActive(false);
        Options.gameObject.SetActive(true);
    }

        // Sección créditos

        public void Creditos()
     {
           Menu.gameObject.SetActive(false);
           Credits.gameObject.SetActive(true);
       }

    public void ReturnT()
    {
        HowTo.gameObject.SetActive(false);
        Menu.gameObject.SetActive(true);
    }

    public void Return()
    {
        Options.gameObject.SetActive(false);
        Menu.gameObject.SetActive(true);
    }

    public void ReturnC()
        {
            Credits.gameObject.SetActive(false);
            Menu.gameObject.SetActive(true);
        }

        public void Salir()
        {
            Application.Quit();
        }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/GerardJuv");
    }

    public void Twitch()
    {
        Application.OpenURL("https://www.twitch.tv/shyvala");
    }

}