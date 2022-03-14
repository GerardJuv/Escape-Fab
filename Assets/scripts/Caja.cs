using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caja : MonoBehaviour {

    public GameObject cajaup;
    public Button BotonUp;
    public Button BotonDown;

    public bool Cogido = false;
    private bool UICanvas = false;

    private void Start()
    {
        UICanvas = false;
    }

    public void OnTriggerEnter(Collider obj)
    {
        BotonUp.gameObject.SetActive(true); 
    }

    private void OnTriggerExit(Collider obj)
    {
        BotonUp.gameObject.SetActive(false);
    }


    // Update is called once per frame
    public void PickUp () {

        Cogido = true;
        BotonUp.gameObject.SetActive(false);
        BotonDown.gameObject.SetActive(true);
        this.GetComponent<Rigidbody>().useGravity = false;
        this.gameObject.transform.SetParent(GameObject.Find("PuntoCaja").transform, true);
        this.gameObject.transform.localRotation = Quaternion.identity;
        this.gameObject.transform.localPosition = Vector3.zero;
        StartCoroutine(WaitandPrint());
        
    }

    IEnumerator WaitandPrint()
    {
        yield return new WaitForSeconds(1);
        Cogido = true;
    }


    public void PickDown()
    {
        Cogido = false;
        BotonDown.gameObject.SetActive(false);
        BotonUp.gameObject.SetActive(false);
    }

    private void Update()
    {
        
        if (Cogido == false)
        {
            this.transform.parent = null;
            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
