using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed;

	private Rigidbody2D rigidBody;

	void Awake () {

		rigidBody = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.A)) //left
		{
			rigidBody.transform.Translate(-Vector2.right * Speed * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.D)) //right
		{
			rigidBody.transform.Translate(Vector2.right * Speed * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.S)) //down
		{
			rigidBody.transform.Translate(-Vector2.up * Speed * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.W)) //up
		{
			rigidBody.transform.Translate(Vector2.up * Speed * Time.deltaTime);
		}
	}
}
