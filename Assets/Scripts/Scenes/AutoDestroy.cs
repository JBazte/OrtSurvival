using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

    private EnemyHealthManager enemy;
    private Killer killer;
    private Animator anim;
    private Target room;
    private EffectsManager sound;

    // Use this for initialization
    void Start () {
        enemy = FindObjectOfType<EnemyHealthManager>();
        killer = FindObjectOfType<Killer>();
        room = FindObjectOfType<Target>();
        anim = room.GetComponent<Animator>();
        sound = FindObjectOfType<EffectsManager>();
        StartCoroutine(Sound());
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.EnemyCurrentHealth <= 0)
        {
            killer.Enemy.Add(name);
            StartCoroutine(Door());
            Destroy(this.gameObject);
        }
    }
    
    IEnumerator Door()
    {
        anim.SetBool("Open", true);
        sound.DoorOpening.Play();
        yield return new WaitForSeconds(0f);
    }

    IEnumerator Sound()
    {
        yield return new WaitForSeconds(.5f);
        sound.DoorClosing.Play();
    }
}
