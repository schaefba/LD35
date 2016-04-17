using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {


	private static GameObject levelFailedPanel;
	private static GameObject menuPanel;

	void Awake () {

		levelFailedPanel = GameObject.Find ("LevelOverPanel");
		menuPanel = GameObject.Find ("MenuPanel");
	}

	// Use this for initialization
	void Start () {
		levelFailedPanel.SetActive (false);
		menuPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void LoadFailedPanel(string failText) {

		levelFailedPanel.SetActive (true);
		Text caughtText = GameObject.Find ("CaughtText").GetComponent<Text>();
		caughtText.text = failText;
	}

	public static void ClearFailedPanel () {

		levelFailedPanel.SetActive (false);
	}

	public static void LoadMenuPanel() {

		menuPanel.SetActive (true);
	}

	public static void ClearMenuPanel() {

		menuPanel.SetActive (false);
	}
}
