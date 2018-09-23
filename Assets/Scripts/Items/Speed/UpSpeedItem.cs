using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSpeedItem : MonoBehaviour {

    private PlayerController thePlayer;
    private Killer kill;
    private Item Items;
    private EffectsManager sound;

    // Use this for initialization
    void Start ()
    {
        sound = FindObjectOfType<EffectsManager>();
        thePlayer = FindObjectOfType<PlayerController>();
        kill = FindObjectOfType<Killer>();
        Items = FindObjectOfType<Item>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.GoodItem.Play();
            kill.Enemy.Add(Items.name);
            thePlayer.moveSpeed = thePlayer.moveSpeed + 2;
            Destroy(Items.gameObject);
        }
    }
}
