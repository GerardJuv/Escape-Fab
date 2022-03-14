using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placa_presion : MonoBehaviour {

    public GameObject plataforma;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "caja")
        {
            plataforma.GetComponent<Animator>().SetBool("Activar", true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "caja")
        {
            plataforma.GetComponent<Animator>().SetBool("Activar", false);
        }
    }
}
