using UnityEngine;
using System.Collections;

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

	public static void LoadFailedPanel() {

		levelFailedPanel.SetActive (true);
	}

	public static void ClearFailedPanel () {

		levelFailedPanel.SetActive (false);
	}
}
