using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string dialogue;
    private DialogueManager dBox;
    public bool isTrigger;
    private Animation anim;
    public GameObject DialogueBox;

    // Use this for initialization
    void Start() {
        dBox = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           DialogueBox.GetComponent<Animation>().Play("NoteMovement");
           isTrigger = true;
           dBox.ShowBox(dialogue);
        }
        else
        {
            isTrigger = false;
        }
    }
}


