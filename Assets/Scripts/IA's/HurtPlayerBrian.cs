using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerBrian : MonoBehaviour {

    public int damageToGive;
    public GameObject TearDestroy;
    public EffectsManager sound;
    private int time;
    private int delay = 50;
    private Animations movement;

    // Use this for initialization
    void Start()
    {
        movement = GetComponent<Animations>();
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
                movement.speed = .1f;
            }
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
                movement.speed = .1f;
            }
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(wait());
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            sound.HurtPlayer.Play();
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }
    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(.1f);
        movement.speed = 1.1f;
    }
}