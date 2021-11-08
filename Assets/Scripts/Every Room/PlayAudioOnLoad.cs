﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnLoad : MonoBehaviour
{

    private AudioSource source;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
        source.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}