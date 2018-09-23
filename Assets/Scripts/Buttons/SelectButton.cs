using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour {
    
    public Button Button;
    public KeyCode Key;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown(Key))
        {
            anim.SetBool("Highlighted", true);
            Button.onClick.Invoke();
            anim.SetBool("Pressed", true); 
        }
    }
}
