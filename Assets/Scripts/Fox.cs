using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
[RequireComponent (typeof (Animator))]

public class Fox : MonoBehaviour {


	private Animator animator;
	private Attacker attacker;

	void Start() {
		animator = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
	}
	void OnTriggerEnter2D(Collider2D col) {
		GameObject colObject = col.gameObject;
		if (!(colObject.GetComponent<Defender> () || colObject.GetComponent<Projectile>())) {
			return;
		}
		if (colObject.GetComponent<Projectile> () || colObject.GetComponent<Stone> ()) {
			animator.SetTrigger ("Jump");
		} else {
			attacker.Attack(colObject.GetComponent<Defender>());
		}

	}

}