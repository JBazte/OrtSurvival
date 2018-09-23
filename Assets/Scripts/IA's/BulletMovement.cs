using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
	public float BulletSpeed;

	Vector3 targeteano;
	Transform player;
	Rigidbody2D rb;
	public int timebeforedestroy;
	int time;
	//Call every frame
	void Start(){
		rb=gameObject.GetComponent<Rigidbody2D>();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		//target = player.transform.position - transform.position;
		targeteano = player.transform.position - transform.position;
	}
    void FixedUpdate() {
        //rb.AddForce(Vector2.MoveTowards(transform.position,targeteano,BulletSpeed*Time.deltaTime));
        rb.velocity = new Vector2(targeteano.x, targeteano.y).normalized * BulletSpeed * Time.deltaTime;
       // rb.AddForce(new Vector2(targeteano.x, targeteano.y)*BulletSpeed,ForceMode2D.Force);


    }
    void Update(){ 
		//transform.position = Vector2.MoveTowards (transform.position, targeteano, BulletSpeed * Time.deltaTime);
		//rb.AddForce(Vector2.MoveTowards(transform.position,targeteano,0));
		time++;
		if (time > timebeforedestroy) {
			Destroy (gameObject);
			time = 0;
		}
	}
}