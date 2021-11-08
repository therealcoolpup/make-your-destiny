﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOutController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kid")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("5");
        }
    }
}
