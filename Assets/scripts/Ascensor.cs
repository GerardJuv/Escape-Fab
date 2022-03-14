using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour {

    public GameObject ascensor;

    void OnTriggerEnter(Collider obj)
    {
        ascensor.GetComponent<Animator>().SetTrigger("Activar");
    }
}
