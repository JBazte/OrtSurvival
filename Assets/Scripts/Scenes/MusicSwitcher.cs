﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour {

    private MusicController theMC;
    public int newTrack;
    public bool switchOnStart;

	// Use this for initialization
	void Start () {
        theMC = FindObjectOfType<MusicController>();
        if (switchOnStart)
        {
            theMC.SwitchTrack(newTrack);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            theMC.SwitchTrack(newTrack);
        }
    }
}
