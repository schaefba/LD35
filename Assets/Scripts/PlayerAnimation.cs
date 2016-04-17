using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(animator)
		{

			if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) //left
			{
				animator.SetBool("player_walk", true);
				animator.SetBool("player_idle", false);
				
			}
			else
            {
                animator.SetBool("player_idle", true);
                animator.SetBool("player_walk", false);
            }
		}
	}
}
