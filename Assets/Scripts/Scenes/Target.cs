using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public EnemyHealthManager enemy;
    private AutoDestroy door;
    private EffectsManager sound;
    private Animator anim;
    private Target room;
    private bool killed = false;

    // Use this for initialization
    void Start () {
        enemy = FindObjectOfType<EnemyHealthManager>();
        sound = FindObjectOfType<EffectsManager>();
        room = FindObjectOfType<Target>();
        anim = room.GetComponent<Animator>();
        killed = true;
    }

    // Update is called once per frame
    void Update () {
        if (killed)
        {
            StartCoroutine(sdd());
            killed = false;
        }
    }

    IEnumerator sdd()
    {
            yield return new WaitForSeconds(.5f);
            if (enemy == null)
            {
                StartCoroutine(Door());
            }
    }

    IEnumerator Door()
    {
        anim.SetBool("Open", true);
        sound.DoorOpening.Play();
        yield return new WaitForSeconds(0f);
    }
}
