using UnityEngine;
using System.Collections;

public class Fox : MonoBehaviour {

	public Animator animator;
	public float xVel;

	public const int STATE_IDLE = 0;
	public const int STATE_WALKING = 1;
	public const int STATE_JUMPING = 2;
	public const int STATE_TAUNTING = 3;

	private Vector3 vel;
	private Vector3 pos;
	private int state = 0;
	private int stateAtJump;
	private bool walkingEnabled = true;


	// Use this for initialization
	void Start () {
		vel = transform.parent.gameObject.rigidbody2D.velocity;
		pos = transform.parent.position;
	}
	
	// Update is called once per frame
	void Update () {
		vel.x = 0;
		HandleInput ();
		UpdatePhysics ();
	}

	void HandleInput() {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			WalkLeft ();
		} else if(Input.GetKeyUp (KeyCode.LeftArrow)){
			Idle();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump();
		}
	}

	void WalkLeft() {
		if (state != STATE_WALKING && state != STATE_JUMPING) {
			state = 1;
			animator.SetInteger("state", state);
		}
		if (walkingEnabled) {
			vel.x = xVel;
		}
	}

	void Jump() {
		if (state == STATE_JUMPING) {
			return;
		} else {
			stateAtJump = state;
			state = STATE_JUMPING;
			animator.SetInteger("state", state);
		}
	}

	public void Idle() {
		if (state == STATE_IDLE) {
			return;
		}
		state = STATE_IDLE;
		animator.SetInteger ("state", state);
	}

	public void SetAnimationState(int state) {
		if (this.state == state)
			return;
		this.state = state;
		animator.SetInteger ("state", state);
	}

	public int GetStateAtJump() {
		return stateAtJump;
	}

	public void SetWalkingEnabled(bool walkingEnabled) {
		this.walkingEnabled = walkingEnabled;
	}

	void UpdatePhysics() {
		transform.parent.gameObject.rigidbody2D.velocity = vel;
	}

	public void EndJump() {
		SetWalkingEnabled (true);
		SetAnimationState (GetStateAtJump ());
	}
	
	public void Land() {
		SetWalkingEnabled (false);
	}
}
