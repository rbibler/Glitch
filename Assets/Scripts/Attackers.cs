using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {
	[Range (-3f, 3f)]
	public float xVel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * xVel * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log (gameObject + " Collided with: " + col.gameObject);
	}
	
	public void SetSpeed(float xVel) {
		this.xVel = xVel;
	}
}
