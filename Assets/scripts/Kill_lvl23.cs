using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_lvl23 : MonoBehaviour {

    public GameObject Personaje;


    public void OnTriggerEnter(Collider obj)
    {
        Personaje.GetComponent<Transform>().localPosition = new Vector3(200, 30, 215);

    }
}
