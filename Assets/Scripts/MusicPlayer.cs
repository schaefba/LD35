using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static bool AudioBegin = false; 
	public AudioSource audio;

	void Awake()
	{
		if (!AudioBegin) {
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
