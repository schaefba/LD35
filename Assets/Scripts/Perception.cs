using UnityEngine;
using System.Collections;

public class Perception : MonoBehaviour {

	public float viewRange;

	private float sqrViewRange;
	private GameObject player;
    private Light pointLight;
	private ShapeShift playerShapeShift;

    void Awake() {
		//sqrViewRange = viewRange * viewRange;
	}

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
        pointLight = gameObject.transform.FindChild("Area Light").GetComponent<Light>();
		playerShapeShift = player.GetComponent<ShapeShift>();

        sqrViewRange = viewRange * viewRange;
        pointLight.range = sqrViewRange;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.timeScale == 0) {
			return;
		}

        Debug.DrawLine(gameObject.transform.position, new Vector3(gameObject.transform.position.x - viewRange, gameObject.transform.position.y, 0), Color.red, Time.deltaTime, false);

        if (playerShapeShift.isShifted ()) {

			Vector2 directionToPlayer = player.transform.position - gameObject.transform.position;//Vector2.Distance (gameObject, playerShapeShift.gameObject);
            

            if (directionToPlayer.sqrMagnitude <= sqrViewRange) {
				//Debug.Log ("Within range");
				RaycastHit2D hit = Physics2D.Raycast (gameObject.transform.position, directionToPlayer);
                // Player is within view range of the "enemy"
				if (hit != null) {
					
					if (hit.transform == player.transform) {
						//Debug.Log ("I CAN SEE THE PLAYER NOW");
						GameManager.LevelFailed ("Someone saw you and called the police!", "Static_Assets/police-captured", "Sounds/police-siren");
						// enemy can see the player!
					} else {
						
						// there is something obstructing the view
					}
				}
			}
		}
	}
}
