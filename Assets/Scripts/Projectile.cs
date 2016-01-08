using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed;
	public float damage;

	void Update() {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col) {
		Attacker attacker = col.gameObject.GetComponent<Attacker> ();
		if (!attacker) {
			return;
		}
		attacker.TakeDamage (damage);
		Destroy (gameObject);
	}
}
