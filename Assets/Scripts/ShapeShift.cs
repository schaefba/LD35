﻿using UnityEngine;
using System.Collections;

public class ShapeShift : MonoBehaviour {

	public float minimumTimeUntilShift;
	public float maximumTimeUntilShift;
	//public Sprite shiftedSprite;
	public float timeForShift;

	private SpriteRenderer spriteRenderer;
	private Sprite originalSprite;
    private Sprite demonSprite;
    private bool shifting;
	private bool shifted;
	//private float secondsUntilShift;
	//private Time

	void Awake () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		originalSprite = spriteRenderer.sprite;
        demonSprite = Resources.Load<Sprite>("Sprites/Demon_Idle");

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
			StartCoroutine (WaitAndShift (secondsUntilShift));
		}
		//yield waitAndShift(secondsUntilShift);
		
		//StartCoroutine (waitAndShiftBack());

	}

	IEnumerator WaitAndShift(float secondsUntilShift) {

		shifting = true;
		yield return new WaitForSeconds (secondsUntilShift);
		for(int i = 0; i < 6; i++)
		{
			spriteRenderer.color = Color.red;
			yield return new WaitForSeconds(.25f - (i*.02f));
			spriteRenderer.color = Color.white;
			yield return new WaitForSeconds(.25f - (i*.02f));
		}

		spriteRenderer.color = Color.red;
		shifted = true;
        spriteRenderer.sprite = demonSprite;
		yield return new WaitForSeconds (timeForShift);

		spriteRenderer.color = Color.white;
		shifted = false;
		shifting = false;
        spriteRenderer.sprite = originalSprite;

    }

	public bool isShifted() {

		return shifted;
	}

}
