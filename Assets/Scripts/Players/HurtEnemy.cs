using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

    public int damageToGive;
    public GameObject TearDestroy;
    private SpriteRenderer Tear;

    // Use this for initialization
    void Start()
    {
        Tear = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Tear.flipX = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DarioToPlayer" || other.gameObject.tag == "PaulaToPlayer")
        {
           
        }
        else if (other.gameObject.tag == "ClonToPlayer")
        {
            other.gameObject.GetComponent<ClonHealthManager>().HurtEnemy(damageToGive);
            Instantiate(TearDestroy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "ProjectileToPlayer")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Instantiate(TearDestroy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Background")
        {
            Instantiate(TearDestroy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
