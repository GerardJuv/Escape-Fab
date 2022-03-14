using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Press_button_2 : MonoBehaviour {

    public GameObject plataforma1;
    public GameObject plataforma2;
    public GameObject plataforma3;
    public Button Boton;
    public bool IsActivated = false;  
    
    void OnTriggerEnter(Collider obj)
    {
        Boton.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider obj)
    {
        Boton.gameObject.SetActive(false);
    }   

    
    public void Acción()
    {
        if (IsActivated == false)
        {
            FindObjectOfType<AudioManager>().Play("Sonido_Boton");
            plataforma1.GetComponent<Animator>().SetBool("Activar", true);
            plataforma2.GetComponent<Animator>().SetBool("Activar", true);
            plataforma3.GetComponent<Animator>().SetBool("Activar", true);
            IsActivated = true;
        }
        else if (IsActivated == true)
        {
            FindObjectOfType<AudioManager>().Play("Sonido_Boton");
            plataforma1.GetComponent<Animator>().SetBool("Activar", false);
            plataforma2.GetComponent<Animator>().SetBool("Activar", false);
            plataforma3.GetComponent<Animator>().SetBool("Activar", false);
            IsActivated = false;
        }
    }
}
