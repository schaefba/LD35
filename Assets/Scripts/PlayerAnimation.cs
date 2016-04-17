using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	Animator animator;
    ShapeShift shapeShift;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();
        shapeShift = GetComponent<ShapeShift>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(animator)
		{

			if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) //left
			{
                if (shapeShift.isShifted())
                {
                    animator.SetBool("demon_walk", true);
                    animator.SetBool("player_walk", false);     
                }
                else
                {
                    animator.SetBool("player_walk", true);
                    animator.SetBool("demon_walk", false);
                }
                    
				animator.SetBool("player_idle", false);
                animator.SetBool("demon_idle", false);
            }
			else
            {
                if(shapeShift.isShifted())
                {
                    animator.SetBool("demon_idle", true);
                    animator.SetBool("player_idle", false);
                }
                else
                {
                    animator.SetBool("player_idle", true);
                    animator.SetBool("demon_idle", false);
                }

                animator.SetBool("player_walk", false);
                animator.SetBool("demon_walk", false);
            }
		}
	}
}
