using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private float xVel;
	public Animator animator;
	
	private Defender currentTarget;
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
	
	public void DealDamageToCurrentTarget(float damageToInflict) {
		if(currentTarget) {
			if(currentTarget.TakeDamage(damageToInflict)) {
				CancelAttack();
			}
		}
	}
	
	public void Attack(Defender target) {
		currentTarget = target;
		animator.SetBool ("isAttacking", true);
	}
	
	public void CancelAttack() {
		currentTarget = null;
		animator.SetBool ("isAttacking", false);
	}
}
