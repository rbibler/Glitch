using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
[RequireComponent (typeof (Animator))]
public class Jabba : MonoBehaviour {

	private Animator animator;
	private Attacker attacker;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		GameObject colliderObject = collider.gameObject;

		if (!colliderObject.GetComponent<Defender> ()) {
			return;
		}
		attacker.Attack (colliderObject.GetComponent<Defender>());
	}
}
