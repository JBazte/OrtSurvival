using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectText : MonoBehaviour {

    private Text tx;

	// Use this for initialization
    void Start(){
        tx = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.U) || (Input.GetKeyDown(KeyCode.Q)))
        {
            tx.text = "Medios";
        }
        else if (Input.GetKeyDown(KeyCode.R) || (Input.GetKeyDown(KeyCode.L)))
        {
            tx.text = "Diseño";
        }
        else if (Input.GetKeyDown(KeyCode.Y) || (Input.GetKeyDown(KeyCode.O)))
        {
            tx.text = "Gestión";
        }
        else if (Input.GetKeyDown(KeyCode.T) || (Input.GetKeyDown(KeyCode.X)))
        {
            tx.text = "Tic";
        }
	}
}