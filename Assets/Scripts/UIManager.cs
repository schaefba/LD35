using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {


	private static GameObject levelFailedPanel;
	private static GameObject menuPanel;
	private static GameObject loadScreen;
    private static GameObject victoryScreen;

    void Awake () {

		levelFailedPanel = GameObject.Find ("LevelOverPanel");
		menuPanel = GameObject.Find ("MenuPanel");
		loadScreen = GameObject.Find ("LoadScreen");
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            victoryScreen = GameObject.Find("VictoryScreen");
        }
    }

	// Use this for initialization
	void Start () {
		levelFailedPanel.SetActive (false);
		menuPanel.SetActive (false);
		loadScreen.SetActive (false);
        if(victoryScreen != null) { victoryScreen.SetActive(false); }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void ShowFailedPanel(string failTextValue, string imageName) {

		levelFailedPanel.SetActive (true);
		Text failText = GameObject.Find ("FailText").GetComponent<Text>();
		failText.text = failTextValue;

		Image failImage = GameObject.Find ("FailImage").GetComponent<Image> ();
		failImage.sprite = Resources.Load<Sprite> (imageName);
	}

	public static void HideFailedPanel () {

		levelFailedPanel.SetActive (false);
	}

	public static void ShowMenuPanel() {

		menuPanel.SetActive (true);
	}

	public static void HideMenuPanel() {

		menuPanel.SetActive (false);
	}

	/// <summary>
	/// Shows the load screen.
	/// </summary>
	/// <param name="sceneNumber">The raw value of the scene number for the next scene to be loaded.</param>
	public static void ShowLoadScreen (int sceneNumber) {

		loadScreen.SetActive (true);
		Text levelText = GameObject.Find ("LoadLevelNumberText").GetComponent<Text> ();

		// We need to add one since indices for scenes start at zero, but we also need to skip the intro scenes in the count
		levelText.text = string.Format ("Level {0}", (sceneNumber + 1) - GameManager.numberOfIntroScenes); 
	}

    public static void ShowVictoryScreen()
    {
        Time.timeScale = 0f;
        if (victoryScreen != null) { victoryScreen.SetActive(true); }
    }

}
