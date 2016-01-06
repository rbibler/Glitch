using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {
	[Range (-3f, 3f)]
	public float xVel;
	public Animator animator;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * xVel * Time.deltaTime);
	}
	

	
	public void SetSpeed(float xVel) {
		this.xVel = xVel;
	}
	
	public void Attack() {
		animator.SetBool ("isAttacking", true);
	}
	
	public void CancelAttack() {
		animator.SetBool ("isAttacking", false);
	}
}
