using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	public float timeForLevel;
	public GameManager gameManager;

	private float timeLeft;

	void Awake () {

		timeLeft = timeForLevel;
	}

	// Use this for initialization
	void Start () {

		timerText = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.timeScale == 0) {
			return;
		}

		timeLeft -= Time.deltaTime;

		if (timeLeft <= 0) {
			timerText.text = "0 Seconds";
			GameManager.LevelFailed ("You ran out of time!");
		} else {
			timerText.text = System.String.Format ("{0} Seconds", Mathf.Round (timeLeft));
		}
	}
}
