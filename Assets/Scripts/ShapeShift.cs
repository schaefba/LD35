using UnityEngine;
using System.Collections;

public class ShapeShift : MonoBehaviour {

	public float minimumTimeUntilShift;
	public float maximumTimeUntilShift;
	//public Sprite shiftedSprite;
	public float timeForShift;

	private SpriteRenderer spriteRenderer;
	private Sprite originalSprite;
	private bool transforming;
	//private float secondsUntilShift;
	//private Time

	void Awake () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		originalSprite = spriteRenderer.sprite;
		transforming = false;
	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
		float secondsUntilShift = Random.Range (minimumTimeUntilShift, maximumTimeUntilShift);
		if (!transforming) {
			StartCoroutine (waitAndShift (secondsUntilShift));
		}
		//yield waitAndShift(secondsUntilShift);
		
		//StartCoroutine (waitAndShiftBack());

	}

	IEnumerator waitAndShift(float secondsUntilShift) {

		transforming = true;
		yield return new WaitForSeconds (secondsUntilShift);
		spriteRenderer.color = Color.red;
		yield return new WaitForSeconds (timeForShift);
		spriteRenderer.color = Color.white;
		transforming = false;
	}
}
