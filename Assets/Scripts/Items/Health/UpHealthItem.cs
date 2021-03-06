﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpHealthItem : MonoBehaviour {

    private Killer kill;
    private PlayerHealthManager thePlayer;
    private Item Items;
    private EffectsManager sound;

    // Use this for initialization
    void Start()
    {
        sound = FindObjectOfType<EffectsManager>();
        thePlayer = FindObjectOfType<PlayerHealthManager>();
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
            if (thePlayer.playerCurrentHealth < 10)
            {
                sound.GoodItem.Play();
                kill.Enemy.Add(Items.name);
                thePlayer.playerCurrentHealth = thePlayer.playerCurrentHealth + 2;
                Destroy(Items.gameObject);
            }
            else
            {
                sound.GoodItem.Play();
                kill.Enemy.Add(Items.name);
                Destroy(Items.gameObject);
            }
        }
    }
}