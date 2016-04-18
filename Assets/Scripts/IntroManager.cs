using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

	private string[] introTexts = new string[] {
		"\"The devil is inside you!\" the old man yells as he runs into the alley ahead of you.",

		"What the hell was that about? He's probably just a crazy old man ...",

		"As you round the last corner before your home, you start to feel something moving around in your stomach.\n\n" +
		"You fall to the ground on your knees, clenching your stomach in pain. The pain becomes unbearable as your vision becomes red.",

		"Suddenly, the pain subsides.\n\n" +
		"You look at the puddle in front of you, but you do not see yourself looking back. Instead, you see a hideous demon.",

		"You sprint down the last block towards your house. Grasping at the door, you get inside before anyone sees you.\n\n" +
		"There you are, looking at yourself in the bathroom mirror. And its you. But where's the demon?\n\n",

		"Until you can fix your sudden shapeshifting, you need to continue going about your daily activities. "+
		"If anyone was to see you shapeshift into your demonic form, they would almost certainly call the police.",

		"Use WASD to control your character.\n\n" +
		"You will randomly shapeshift into your demonic form as you are trying to get to work. You need to avoid being seen whenever you are in your demon form, while still making it to work on time.\n\n"+ 
		"If the timer reaches 0 seconds, you've missed your deadline for getting to work.\n\n" +
		"Press 'next' to start the game."
	};

	private int textPosition = 0;

	public Text introText;
	public int numberOfIntroScenes;

	// Use this for initialization
	void Start () {
		introText.text = introTexts [textPosition];
		textPosition++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Proceed() {

		if (textPosition < introTexts.Length) {

			introText.text = introTexts [textPosition];
			textPosition++;
		} 
		else {
			GameObject introMusicPlayer = GameObject.Find ("IntroMusic");
			GameObject.Destroy (introMusicPlayer);
			SceneManager.LoadScene (numberOfIntroScenes);
		}
	}
}
