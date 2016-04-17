using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {


	private static GameObject levelFailedPanel;

	void Awake () {

		levelFailedPanel = GameObject.Find ("LevelOverPanel");
		levelFailedPanel.SetActive (false);
	}

	// Use this for initialization
	void Start () {
	
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
}
