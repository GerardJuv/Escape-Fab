using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_lvl3 : MonoBehaviour {
    public GameObject Personaje;
    public Collider Trigger;
   
    public void OnTriggerEnter(Collider Trigger)
    {
        Debug.Log("Contacto4");
        Personaje.GetComponent<Transform>().localPosition = new Vector3 (137, 45, -161);
   //         TransformPoint(137, 15, -161);

    }
}
