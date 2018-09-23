using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownDamageItem : MonoBehaviour
{

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
            if (thePlayer.currentDamage > 7)
            {
                sound.BadItem.Play();
                kill.Enemy.Add(Items.name);
                thePlayer.currentDamage = thePlayer.currentDamage - 2;
                Destroy(Items.gameObject);
            }
            else
            {
                sound.BadItem.Play();
                kill.Enemy.Add(Items.name);
                Destroy(Items.gameObject);
            }
        }
    }
}