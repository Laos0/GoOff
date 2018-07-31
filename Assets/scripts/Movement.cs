using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		speed = 15f;
	}
	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "enemy")
		{
			speed = 5f;
		}

		if (col.gameObject.name == "ice") {
			speed = 25f;
		}

		if (col.gameObject.name == "sand") {
			speed = 10f;
		}

		if (col.gameObject.name == "quickSand") {
			speed = 3f;
		}

		if (col.gameObject.name != "quickSand" || col.gameObject.name != "ice" || col.gameObject.name != "player" || col.gameObject.name != "sand") {
			Invoke ("resetSpeed", 1f);
		}
	}

	void resetSpeed(){
		speed = 15f;
	}
}
