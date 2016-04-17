using UnityEngine;
using System.Collections;

public class MenuListener : MonoBehaviour {

	//UIManager UI;

	private bool menuLoaded;

	void Awake() {

		menuLoaded = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape) ) {

			if (menuLoaded == false) {
				
				UIManager.LoadMenuPanel ();
				Time.timeScale = 0.0f;
				menuLoaded = true;
			} else {

				UIManager.ClearMenuPanel ();
				Time.timeScale = 1.0f;
				menuLoaded = false;
			}
		}
			
	}
}
