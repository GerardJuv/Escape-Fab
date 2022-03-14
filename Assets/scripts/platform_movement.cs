﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_movement : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Player")
            {
            collision.collider.transform.SetParent(transform);
            }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }
}
