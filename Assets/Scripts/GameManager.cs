using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	//private

	//public static UIManager UI;

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {

		Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void LevelFailed (string failText) {

		UIManager.LoadFailedPanel (failText);
		Time.timeScale = 0.0f;
	}

	public void RestartLevel () {

		Time.timeScale = 1.0f;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

		//UIManager.ClearFailedPanel ();
	}

	public void RestartGame () {

		Time.timeScale = 1.0f;
		SceneManager.LoadScene (0);
	}

	public void QuitGame () {
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif 
	}

}
