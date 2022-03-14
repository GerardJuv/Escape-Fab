using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa_presion2 : MonoBehaviour {

    public GameObject plataforma;
    public GameObject puerta;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "caja")
        {
            plataforma.GetComponent<Animator>().SetBool("Activar", true);
            puerta.GetComponent<Animator>().SetBool("Activar", true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "caja")
        {
            plataforma.GetComponent<Animator>().SetBool("Activar", false);
            puerta.GetComponent<Animator>().SetBool("Activar", false);
        }
    }
}
