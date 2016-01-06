using UnityEngine;
using System.Collections;

public class Fox : Attackers {

	public Animator animator;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "projectile") {
			animator.SetTrigger(0);
		}

	}

}