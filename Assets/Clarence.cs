using UnityEngine;
using System.Collections;

public class Clarence : MonoBehaviour {

	public Animator animator;
	public float timeBetweenAttacks;
	
	private float lastAttackTime;
	private Attackers attacker;
	
	void Start() {
		attacker = GetComponentInParent<Attackers>() as Attackers;
		lastAttackTime = Time.timeSinceLevelLoad;
	}
	
	void Update() {
		if(Time.timeSinceLevelLoad - lastAttackTime > timeBetweenAttacks) {
			attacker.Attack();
			lastAttackTime = Time.timeSinceLevelLoad;
		}
	}
	
	
}
