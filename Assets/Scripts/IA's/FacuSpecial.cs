using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacuSpecial : MonoBehaviour {

	public Transform Player;
	public float speed = 2f;
	private float minDistance = 0.2f;
	private float range;	
	public float SpecialAttackCD;
	private float delay;
	private float speedduration = 100;
	private float time;
	private Animator anim;
	float DifX;
	float DifY;
    private PlayerController thePlayer;

    //Call every frame
    void Start(){
        thePlayer = FindObjectOfType<PlayerController>();
        anim = GetComponent<Animator> ();
        Player = thePlayer.transform;
    }
    void FixedUpdate()
		{
		
		DifX = Mathf.Abs(transform.position.x) - Mathf.Abs(Player.transform.position.x);
		DifY = Mathf.Abs(transform.position.y) - Mathf.Abs(Player.transform.position.y);
		DifX = Mathf.Abs (DifX);
		DifY = Mathf.Abs (DifY);
		if (DifX > DifY) {

			if (Player.transform.position.x > transform.position.x) {
				anim.SetBool ("Right", true);
				anim.SetBool ("Left", false);
				anim.SetBool ("Up", false);
				anim.SetBool ("Down", false);


			} if (Player.transform.position.x<transform.position.x) {
				anim.SetBool ("Right", false);
				anim.SetBool ("Left", true);
				anim.SetBool ("Up", false);
				anim.SetBool ("Down", false);
			}
		} 
		if (DifY>DifX) {
			if (Player.transform.position.y > transform.position.y) {
				
				anim.SetBool ("Right", false);
				anim.SetBool ("Left", false);
				anim.SetBool ("Up", true);
				anim.SetBool ("Down", false);

			} if (Player.transform.position.y < transform.position.y) {

				anim.SetBool ("Right", false);
				anim.SetBool ("Left", false);
				anim.SetBool ("Up", false);
				anim.SetBool ("Down", true);
			}

		}
		delay++;	
		time++;
		if (delay > SpecialAttackCD) {
			speed = speed + 2;
			delay = 0;
        
		}
			if (time > speedduration) {
				speed = 2;
				time = 0;
        
			}


			

			Player = GameObject.FindWithTag ("Player").transform;
			range = Vector2.Distance (transform.position, Player.position);
			if (range > minDistance) {
				
				Player = GameObject.FindWithTag ("Player").transform;
				transform.position = Vector2.MoveTowards (transform.position, Player.position, speed * Time.deltaTime);
			}



			
	}


}