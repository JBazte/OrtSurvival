using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    private bool dialogActive;
    private float timer = 1;
    private DialogueHolder holder;

    // Use this for initialization
    void Start () {
        holder = FindObjectOfType<DialogueHolder>();
    }

    // Update is called once per frame
    void Update() {
        if (dialogActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                dBox.SetActive(false);
                dialogActive = false;
            }
        }
           if (dialogActive == false && holder.isTrigger == false)
            {
                timer = 1;
            }
        }
    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }
}
