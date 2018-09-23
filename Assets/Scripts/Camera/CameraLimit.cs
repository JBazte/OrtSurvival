using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLimit : MonoBehaviour {

    private GameObject Camara; 

	// Use this for initialization
	void Start () {
        Camara = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		float limitX = Mathf.Clamp(Camara.transform.position.x, 1, 1);
        float limitY = Mathf.Clamp(Camara.transform.position.y, -0, 0);
        transform.position = new Vector3(limitX, limitY, transform.position.z);
    }
    
}
