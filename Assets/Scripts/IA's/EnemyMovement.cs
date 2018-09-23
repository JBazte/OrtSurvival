using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMovement : MonoBehaviour
{

    public Transform Player;
    public float speed = 2f;
    private float minDistance = 0.2f;
    private float range;
    public GameObject enemy;
    //Call every frame
    void Update()
    {
        Player = GameObject.FindWithTag("Player").transform;
        range = Vector2.Distance(transform.position, Player.position);
        if (range > minDistance)
        {
            Player = GameObject.FindWithTag("Player").transform;
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(enemy);
        }
        if (other.gameObject.tag == "ProyectileToEnemy")
        {
            Destroy(enemy);
        }
    }
}