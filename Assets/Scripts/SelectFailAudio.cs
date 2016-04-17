using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class SelectFailAudio : MonoBehaviour {

	//public AudioSource audioSource;

	static AudioSource audioSource; 

	void Awake() {

		audioSource = GameObject.Find ("LevelOverPanel").GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void SetAudioClip(string clipName) {

		audioSource.clip = Resources.Load (clipName) as AudioClip;
	}

	public static void SetAndPlayAudioClip (string clipName) {

		SetAudioClip (clipName);
		audioSource.Play ();
	}


}
