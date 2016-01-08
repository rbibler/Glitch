using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Defender defender;
	public static Defender selectedDefender;

	private SpriteRenderer renderer;
	private bool selected;


	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		selectedDefender = defender;
		renderer.color = Color.white;
		Button[] buttons = FindObjectsOfType<Button> ();
		foreach (Button button in buttons) {
			if(button != this) {
				button.SetColor(Color.black);
			}
		}
	}

	public void SetColor(Color color) {
		renderer.color = color;
	}
}
