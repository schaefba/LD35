using UnityEngine;
using System.Collections;

public class Perception : MonoBehaviour {

	public float viewRange;

	private float sqrViewRange;
	private GameObject player;
	private ShapeShift playerShapeShift;

	void Awake() {

		sqrViewRange = viewRange * viewRange;
	}

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		playerShapeShift = player.GetComponent<ShapeShift>(); 
	}
	
	// Update is called once per frame
	void Update () {

		if (playerShapeShift.isShifted ()) {

			Vector2 directionToPlayer = player.transform.position - gameObject.transform.position;//Vector2.Distance (gameObject, playerShapeShift.gameObject);

			if (directionToPlayer.sqrMagnitude < sqrViewRange) {
				Debug.Log ("Within range");
				RaycastHit2D hit = Physics2D.Raycast (gameObject.transform.position, directionToPlayer);
				Debug.DrawRay (gameObject.transform.position, directionToPlayer,Color.green);
				// Player is within view range of the "enemy"
				if (hit != null) {
					
					if (hit.transform == player.transform) {
						Debug.Log ("I CAN SEE THE PLAYER NOW");
						// enemy can see the player!
					} else {
						// there is something obstructing the view
					}
				}


			}



			// if within range, raycast
		}
	}
}
