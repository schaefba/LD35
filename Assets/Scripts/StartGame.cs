using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Simple loading of the next scene. Does not handle transitions between gameplay levels. Instead <see cref="LoadNextLevel"/>
	/// </summary>
	public void StartTheGame () {

		SceneManager.LoadScene (1);
	}
}
