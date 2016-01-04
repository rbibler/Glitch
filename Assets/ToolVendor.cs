using UnityEngine;
using System.Collections;

public class ToolVendor : MonoBehaviour {

	public const int STATE_IDLE = 0;
	public const int STATE_WALKING_RIGHT = 1;
	public const int STATE_WALKING_LEFT = 2;
	public const int STATE_TURNING_RIGHT = 3;
	public const int STATE_TURNING_LEFT = 4;

	public Animator animator;
	public float xVel;

	private int state = 0;
	private Vector3 pos;
	private Vector3 vel;

	// Use this for initialization
	void Start () {
		pos = transform.parent.position;
		vel = transform.parent.gameObject.rigidbody2D.velocity;
	}
	
	// Update is called once per frame
	void Update () {
		HandleInput ();
		UpdatePhysics ();
	}

	void HandleInput() {
		vel.x = 0;
		if (Input.GetKey (KeyCode.RightArrow)) {
			WalkRight ();
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			WalkLeft ();
		} else if (Input.GetKeyUp (KeyCode.RightArrow)) {
			Idle ();
		} else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			IdleLeft ();
		}
	}

	void UpdatePhysics() {
		transform.parent.gameObject.rigidbody2D.velocity = vel;
	}

	void WalkRight() {
		if (animator.GetCurrentAnimationClipState (0) [0].clip.name == "TV_Walk_Right") {
			vel.x = xVel;
		}
		state = STATE_WALKING_RIGHT;
		animator.SetInteger("state", state);
	}

	void WalkLeft() {
		if (animator.GetCurrentAnimationClipState (0) [0].clip.name == "TV_Walk_Left") {
			vel.x = -xVel;
		}
		state = STATE_WALKING_LEFT;
		animator.SetInteger("state", state);
	}

	void Idle() {
		state = STATE_IDLE;
		animator.SetInteger("state", state);
	}

	void IdleLeft() {
		state = STATE_TURNING_RIGHT;
		animator.SetInteger ("state", state);
	}

	public void EndTurnRight() {
		if (state == STATE_TURNING_RIGHT) {
			state = STATE_IDLE;
			animator.SetInteger("state", state);
		}
	}
}
