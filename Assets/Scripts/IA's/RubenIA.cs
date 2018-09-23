using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RubenIA : MonoBehaviour
{

    public Transform player;
    private List<GameObject> Projectiles = new List<GameObject>();
    public GameObject projectilePrefab;
    private float timeBetweenShots;
    public float ShotDelay;
    private PlayerController thePlayer;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        player = thePlayer.transform;
    }
    //Call every frame
    void Update()
    {
        timeBetweenShots++;
        if (timeBetweenShots > ShotDelay)
        {
            GameObject arrow = (GameObject)Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y - .8f, transform.position.z), Quaternion.identity);
            Projectiles.Add(arrow);
            timeBetweenShots = 0;
        }
    }
}
