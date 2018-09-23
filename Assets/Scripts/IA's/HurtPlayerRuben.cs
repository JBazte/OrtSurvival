﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerRuben : MonoBehaviour {

    public int damageToGive;
    public GameObject TearDestroy;
    public EffectsManager sound;
    private int time;
    private int delay = 50;
    private AnimationsRuben ruben;
    private RubenIA spawn;

    // Use this for initialization
    void Start()
    {
        spawn = FindObjectOfType<RubenIA>();
        ruben = FindObjectOfType<AnimationsRuben>();
        sound = FindObjectOfType<EffectsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        time++;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (time > delay)
            {
                sound.HurtPlayer.Play();
                other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
                time = 0;
                spawn.ShotDelay = 1000;
            }
            ruben.speed = .1f;
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (time > delay)
            {
                sound.HurtPlayer.Play();
                other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
                time = 0;
                spawn.ShotDelay = 1000;
            }
            ruben.speed = .1f;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            spawn.ShotDelay = 10;
            StartCoroutine(wait());
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            sound.HurtPlayer.Play();
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
            Destroy(gameObject);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(.1f);
        ruben.speed = 4;
    }
}