using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {

	public float speed;
	public int counter;
	public GameObject player;

	void Start(){
		speed = .05f;
	}

	// Update is called once per frame
	void FixedUpdate () {

		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);

	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "player")
		{
			speed = 0f;
		}

		if (col.gameObject.name == "ice") {
			speed = .1f;
		}

		if (col.gameObject.name == "sand") {
			speed = .03f;
		}

		if (col.gameObject.name == "quickSand") {
			speed = .01f;
		}

		if (col.gameObject.name != "quickSand" || col.gameObject.name != "ice" || col.gameObject.name != "player" || col.gameObject.name != "sand") {
			Invoke ("resetSpeed", 1f);
		}

	}

	void resetSpeed(){
		speed = .03f;
	}
		
}
