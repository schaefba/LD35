using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighlightGoal : MonoBehaviour {

	public Image goalHighlight;

	void Awake() {

	}

	// Use this for initialization
	void Start () {

		StartCoroutine (FlashGoalHighlight ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator FlashGoalHighlight() {
	
		for (int i = 0; i < 6; i++) {
			
			goalHighlight.enabled = true;
			yield return new WaitForSeconds (.25f);
			goalHighlight.enabled = false;
			yield return new WaitForSeconds (.25f);
		}

	}
}
