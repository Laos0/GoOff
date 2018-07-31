using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
	public GameObject player, enemy;
	// Update is called once per frame
	void FixedUpdate () {

		if (player != null) {
			if (player.transform.position.y < -3) {
				Destroy (player);
			}
		}

		if (enemy != null) {
			if (enemy.transform.position.y < -3) {
				Destroy (enemy);
			}
		}
	}
}
