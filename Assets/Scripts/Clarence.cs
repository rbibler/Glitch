using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Clarence : MonoBehaviour {
	
	public float timeBetweenAttacks;
	
	private float lastAttackTime;
	private Attacker attacker;
	
	void Start() {
		attacker = GetComponent<Attacker>();
		lastAttackTime = Time.timeSinceLevelLoad;
	}
	
	void Update() {
		float time = Time.timeSinceLevelLoad - lastAttackTime;
		print (time);
		if(time > timeBetweenAttacks) {
			attacker.Attack();
			lastAttackTime = Time.timeSinceLevelLoad;
		}
	}
	
	
}
