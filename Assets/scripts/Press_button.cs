using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Press_button : MonoBehaviour
{
    public GameObject puerta;
    public Button Boton;


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
            FindObjectOfType<AudioManager>().Play("Sonido_Boton");
            puerta.GetComponent<Animator>().SetTrigger("Activar");
    }
 
}