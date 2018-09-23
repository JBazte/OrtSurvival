using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.visible = true;
        }
    }
}
