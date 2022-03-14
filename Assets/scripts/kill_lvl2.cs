using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_lvl2 : MonoBehaviour {

    public GameObject Personaje;
    

    public void OnTriggerEnter(Collider obj)
    {
        Personaje.GetComponent<Transform>().localPosition = new Vector3(-220, 30, -550);
        //         TransformPoint(137, 15, -161);

    }   
}

