using UnityEngine;
using System.Collections;

public class Clarence : MonoBehaviour {

	public Animator animator;
	public float horizVel;
	private Vector3 pos;
	private Vector3 vel;
	private int state;

	// Use this for initialization
	void Start () {
		pos = transform.parent.position;
		vel = transform.parent.gameObject.rigidbody2D.velocity;
	}
	
	// Update is called once per frame
	void Update () {
		vel.x = 0;
		if (Input.GetKey (KeyCode.RightArrow)) {
			Walk();
		} else {
			Idle();
		}
		transform.parent.gameObject.rigidbody2D.velocity = vel;
	}

	void Walk() {
		vel.x = horizVel;
		animator.SetInteger ("state", 1);
		state = 1;
	}

	void Idle() {
		if (state == 0) {
			return;
		}
		state = 0;
		animator.SetInteger ("state", state);
	}
}
