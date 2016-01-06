using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	void Start() {
		gameObject.tag = "projectile";
	}

	void OnTriggerEnter2D(Collider2D col) {

		Debug.Log (gameObject + " Collided with: " + col.gameObject);
	}
}
