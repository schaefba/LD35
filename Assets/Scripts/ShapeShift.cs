using UnityEngine;
using System.Collections;

public class ShapeShift : MonoBehaviour {

	public float minimumTimeUntilShift;
	public float maximumTimeUntilShift;
	//public Sprite shiftedSprite;
	public float timeForShift;

	private SpriteRenderer spriteRenderer;
	private Sprite originalSprite;
	private bool shifting;
	private bool shifted;
	//private float secondsUntilShift;
	//private Time

	void Awake () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		originalSprite = spriteRenderer.sprite;
		shifting = false;
		shifted = false;
	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
		float secondsUntilShift = Random.Range (minimumTimeUntilShift, maximumTimeUntilShift);
		if (!shifting) {
			StartCoroutine (waitAndShift (secondsUntilShift));
		}
		//yield waitAndShift(secondsUntilShift);
		
		//StartCoroutine (waitAndShiftBack());

	}

	IEnumerator waitAndShift(float secondsUntilShift) {

		shifting = true;
		yield return new WaitForSeconds (secondsUntilShift);
		for(int i = 0; i < 10; i++)
		{
			spriteRenderer.color = Color.red;
			yield return new WaitForSeconds(.3f - (i*.02f));
			spriteRenderer.color = Color.white;
			yield return new WaitForSeconds(.3f - (i*.02f));
		}
		spriteRenderer.color = Color.red;
		shifted = true;
		yield return new WaitForSeconds (timeForShift);
		spriteRenderer.color = Color.white;
		shifted = false;
		shifting = false;
	}

	public bool isShifted() {

		return shifted;
	}

}
