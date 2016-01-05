using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log (gameObject + " Collided with: " + col.gameObject);
	}
}
