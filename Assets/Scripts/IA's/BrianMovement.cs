using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrianMovement : MonoBehaviour {
	
	public Transform player;
	public float walkingDistance = 10.0f;
	public float smoothTime = 10.0f;
	private Vector3 smoothVelocity = Vector3.zero;
	void Start()
	{


	}
	//Call every frame
	void Update()
	{
		
			//Calculate distance between player
			float distance = Vector3.Distance (transform.position, player.position);
			//If the distance is smaller than the walkingDistance
			if (distance < walkingDistance) {
				//Move the enemy towards the player with smoothdamp
				transform.position = Vector3.SmoothDamp (transform.position, player.position, ref smoothVelocity, smoothTime);
			}
			}
}


