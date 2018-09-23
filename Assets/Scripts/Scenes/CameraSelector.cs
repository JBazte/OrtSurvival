using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSelector : MonoBehaviour {

    private Canvas can;

    // Use this for initialization
    void Start () {
        can = GetComponent<Canvas>();
        can.worldCamera = FindObjectOfType<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
