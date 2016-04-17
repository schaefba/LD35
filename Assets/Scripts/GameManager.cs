using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	//private

	//public static UIManager UI;
	public int introSceneCount;
	public float secondsBetweenLevels;

	public static int numberOfIntroScenes;
	public static float timeBetweenLevels;

	void Awake() {
		DontDestroyOnLoad (gameObject);
		numberOfIntroScenes = introSceneCount;
		timeBetweenLevels = secondsBetweenLevels;
	}

	// Use this for initialization
	void Start () {

		Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void LevelFailed (string failText, string failImageName) {

		UIManager.ShowFailedPanel (failText, failImageName);
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

	/// <summary>
	/// Simple loading of the next scene. Does not handle transitions between gameplay levels. Instead <see cref="LoadNextLevel"/>
	/// </summary>
	public void NextScene () {

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame () {
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif 
	}

}
