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

	}

	void OnTriggerEnter2D(Collider2D collider) {
		GameObject colObject = collider.gameObject;
		print ("Clarence collided with: " + colObject);

		if (!colObject.GetComponent<Defender> ()) {
			return;
		}

		attacker.Attack (colObject.GetComponent<Defender>());
	}
	
	
}
