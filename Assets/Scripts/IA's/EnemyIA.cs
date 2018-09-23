using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyIA : MonoBehaviour{

    public Transform player;
    private List<GameObject> Projectiles = new List<GameObject>();
    public GameObject projectilePrefab;
    private float timeBetweenShots;
    public float ShotDelay;
    private PlayerController thePlayer;

    void Start(){
        thePlayer = FindObjectOfType<PlayerController>();
        player = thePlayer.transform;
    }
    //Call every frame
    void Update(){
            timeBetweenShots++;
            if (timeBetweenShots > ShotDelay)
            {
                GameObject arrow = (GameObject)Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                Projectiles.Add(arrow);
                timeBetweenShots = 0;
            }
        }
    }
