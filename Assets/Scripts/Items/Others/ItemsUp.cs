using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsUp : MonoBehaviour {

    private Killer kill;
    private PlayerShoot thePlayerDamage;
    private PlayerHealthManager thePlayerHealth;
    private PlayerController thePlayerSpeed;
    private Item Items;
    private EffectsManager sound;

    // Use this for initialization
    void Start()
    {
        sound = FindObjectOfType<EffectsManager>();
        thePlayerDamage = FindObjectOfType<PlayerShoot>();
        thePlayerSpeed = FindObjectOfType<PlayerController>();
        thePlayerHealth = FindObjectOfType<PlayerHealthManager>();
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
            thePlayerDamage.currentDamage = thePlayerDamage.currentDamage + 4;
            thePlayerHealth.playerCurrentHealth = thePlayerHealth.playerCurrentHealth + 2;
            thePlayerSpeed.moveSpeed = thePlayerSpeed.moveSpeed + 2;
            Destroy(Items.gameObject);
        }
    }
}