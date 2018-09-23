using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {

	private EnemyIA Player;
	public float speed = 2f;
	private float minDistance = 1f;
	private float range;	
	private Animator anim;
	float DifX;
	float DifY;

	//Call every frame
	void Start(){
		anim = GetComponent<Animator> ();
        Player = GetComponent<EnemyIA>();
	}

	void Update()
		{
		
		DifX = Mathf.Abs(transform.position.x) - Mathf.Abs(Player.player.transform.position.x);
		DifY = Mathf.Abs(transform.position.y) - Mathf.Abs(Player.player.transform.position.y);
		DifX = Mathf.Abs (DifX);
		DifY = Mathf.Abs (DifY);
		if (DifX > DifY) {

			if (Player.player.transform.position.x > transform.position.x) {
				anim.SetBool ("Right", true);
				anim.SetBool ("Left", false);
				anim.SetBool ("Up", false);
				anim.SetBool ("Down", false);


			} if (Player.player.transform.position.x<transform.position.x) {
				anim.SetBool ("Right", false);
				anim.SetBool ("Left", true);
				anim.SetBool ("Up", false);
				anim.SetBool ("Down", false);
			}
		} 
		if (DifY>DifX) {
			if (Player.player.transform.position.y > transform.position.y) {
				
				anim.SetBool ("Right", false);
				anim.SetBool ("Left", false);
				anim.SetBool ("Up", true);
				anim.SetBool ("Down", false);

			} if (Player.player.transform.position.y < transform.position.y) {

				anim.SetBool ("Right", false);
				anim.SetBool ("Left", false);
				anim.SetBool ("Up", false);
				anim.SetBool ("Down", true);
			}

		}
			range = Vector2.Distance (transform.position, Player.player.position);
			if (range > minDistance) {
				transform.position = Vector2.MoveTowards (transform.position, Player.player.position, speed * Time.deltaTime);
			}
	}


}