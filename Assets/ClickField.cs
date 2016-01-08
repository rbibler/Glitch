using UnityEngine;
using System.Collections;

public class ClickField : MonoBehaviour {
	
	void OnMouseDown() {
		Vector3 pos = Input.mousePosition;
		pos.z = 19;
		pos = Camera.main.ScreenToWorldPoint (pos);
		Defender currentDefender = Button.selectedDefender;
		Defender defender = Instantiate (currentDefender) as Defender;
		defender.transform.position = pos;
	}
}
