using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour {

    private GameObject theEnemy;
    private bool active = true;

    // Use this for initialization
    void Start () {
		theEnemy = GameObject.Find("Dario Boss");
    }

    // Update is called once per frame
    void Update () {
        if (theEnemy != null)
        {
            if (theEnemy.GetComponent<EnemyHealthManager>().EnemyCurrentHealth > 0)
            {
                if (Input.GetButtonDown("Cancel") && active == true || Input.GetKeyDown(KeyCode.P) && active == true)
                {
                    theEnemy.SetActive(false);
                    active = false;
                }
                else if (Input.GetButtonDown("Cancel") && active == false || Input.GetKeyDown(KeyCode.P) && active == false)
                {
                    theEnemy.SetActive(true);
                    active = true;
                }
            }
        }
    }
}
