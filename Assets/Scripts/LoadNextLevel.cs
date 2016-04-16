using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.tag == "Player") {

			if (SceneManager.GetActiveScene ().buildIndex < SceneManager.sceneCount + 1) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			} else {
				// No more levels, you beat the game!
			}
		}
	}
}
