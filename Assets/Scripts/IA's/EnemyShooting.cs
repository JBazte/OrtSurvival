using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {


    public GameObject projectileprefab;
    private List<GameObject> Projectiles = new List<GameObject>();
    public int Delay;
    private int time;
    // Use this for initialization
    void Start() {
    }


    void Update()
    {
        time++;
        if (time > Delay) {
            GameObject bullet = Instantiate(projectileprefab, transform.position, Quaternion.identity);
            Projectiles.Add(bullet);

            time = 0;
            //Vector2 target = player.transform.position - transform.position;

            //rb.AddForce (target * BulletSpeed);
            //rb.AddForce (Vector2.up * BulletSpeed);
        }
    }
}
	//IEnumerator Timer (){
//		yield return new WaitForSeconds (5);


	