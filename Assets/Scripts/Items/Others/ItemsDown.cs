using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsDown : MonoBehaviour {

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
        thePlayerSpeed = FindObjectOfType<PlayerController>();
        thePlayerHealth = FindObjectOfType<PlayerHealthManager>();
        thePlayerDamage = FindObjectOfType<PlayerShoot>();
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
            if (thePlayerSpeed.moveSpeed > 6 && thePlayerDamage.currentDamage > 7)
            {
                sound.BadItem.Play();
                kill.Enemy.Add(Items.name);
                thePlayerDamage.currentDamage = thePlayerDamage.currentDamage - 2;
                thePlayerSpeed.moveSpeed = thePlayerSpeed.moveSpeed - 2;
                thePlayerHealth.playerCurrentHealth = thePlayerHealth.playerCurrentHealth - 2;
                Destroy(Items.gameObject);
            }
            else if(thePlayerSpeed.moveSpeed > 6)
            {
                sound.BadItem.Play();
                kill.Enemy.Add(Items.name);
                thePlayerSpeed.moveSpeed = thePlayerSpeed.moveSpeed - 2;
                thePlayerHealth.playerCurrentHealth = thePlayerHealth.playerCurrentHealth - 2;
                Destroy(Items.gameObject);
            }
            else if (thePlayerDamage.currentDamage > 7)
            {
                sound.BadItem.Play();
                kill.Enemy.Add(Items.name);
                thePlayerDamage.currentDamage = thePlayerDamage.currentDamage - 2;
                thePlayerHealth.playerCurrentHealth = thePlayerHealth.playerCurrentHealth - 2;
                Destroy(Items.gameObject);
            }
            else
            {
                sound.BadItem.Play();
                kill.Enemy.Add(Items.name);
                thePlayerHealth.playerCurrentHealth = thePlayerHealth.playerCurrentHealth - 2;
                Destroy(Items.gameObject);
            }
        }
    }
}