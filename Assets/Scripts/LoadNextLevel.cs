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

				UIManager.ShowLoadScreen (SceneManager.GetActiveScene ().buildIndex + 1);
				StartCoroutine (WaitAndLoadLevel ());

			} else {
				// No more levels, you beat the game!
			}
		}
	}

	IEnumerator WaitAndLoadLevel() {

		// disable sound and other game systems
		Time.timeScale = 0.0f;

		float start = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup < start + GameManager.timeBetweenLevels)
		{
			yield return null;
		}

		//yield return new WaitForSeconds(timeBetweenLevels);

		// re-enable sound and other game systems
		Time.timeScale = 1.0f;

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
