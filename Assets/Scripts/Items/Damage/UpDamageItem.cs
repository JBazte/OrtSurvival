using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDamageItem : MonoBehaviour{

    private Killer kill;
    private PlayerShoot thePlayer;
    private Item Items;
    private EffectsManager sound;

    // Use this for initialization
    void Start()
    {
        sound = FindObjectOfType<EffectsManager>();
        thePlayer = FindObjectOfType<PlayerShoot>();
        kill = FindObjectOfType<Killer>();
        Items = FindObjectOfType<Item>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.GoodItem.Play();
            kill.Enemy.Add(Items.name);
            thePlayer.currentDamage = thePlayer.currentDamage + 4;
            Destroy(Items.gameObject);
        }
    }
}   