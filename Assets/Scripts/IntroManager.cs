using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

	private string[] introTexts = new string[] {
		"You're a pretty normal person. You go to work. You get groceries. You go on dates. " +
		"\n\nExcept you're a shapeshifter. And all of your life you've been able to control your ability." +
		" You could shapeshift at will. So it hasn't caused you any problems.",

		"Recently, you've started shifting at random intervals, with no rhyme or reason. \n\n" +
		"This poses a pretty big problem - if people were to see your true form, " +
		"they would certainly freak out and call the police or the army, or who knows what!",

		"You just want to go about your life - go to work, get some pastries, eat some cake. Whatever! " +
		"But now you need to be extra careful! If you get seen while shapeshifted, you could end up in jail ... or worse."
	};

	private int textPosition = 0;

	public Text introText;


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

			SceneManager.LoadScene (GameManager.numberOfIntroScenes);
		}
	}
}
