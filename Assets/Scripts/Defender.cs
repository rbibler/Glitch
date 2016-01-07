using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Health))]
public class Defender : MonoBehaviour {

	private Health health;
	
	void Start() {
		health = GetComponent<Health>();
	}

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log (gameObject + " Collided with: " + col.gameObject);
	}
	
	public bool TakeDamage(float damageToTake) {
		float remainingHealth = health.ReduceHealth(damageToTake);
		if(remainingHealth < 0) {
			Destroy (gameObject);
			return true;
		}
		return false;
	}
}
