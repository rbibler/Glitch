using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] musicOrderChangeArray;
	
	private AudioSource audioSource;

	void Awake() {
		DontDestroyOnLoad(gameObject);
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level) {
		AudioClip thisLevelsMusic = musicOrderChangeArray[level];
		if(level == 2 || thisLevelsMusic == audioSource.clip) {
			return;
		}
		if(thisLevelsMusic) {
			audioSource.clip = thisLevelsMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
}
