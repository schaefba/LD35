using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	void Awake() {
		Debug.Log ("Main menu awake");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Simple loading of the next scene. Does not handle transitions between gameplay levels. Instead <see cref="LoadNextLevel"/>
	/// </summary>
	public void StartGame () {

		SceneManager.LoadScene (1);
	}

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
    }
}
