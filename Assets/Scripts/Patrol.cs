// Patrol.cs
using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour
{

    public Transform[] Points;
    public int Speed;

    private Transform transform;
    private int destPoint = 0;

    void Start()
    {
        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        //GotoNextPoint();
        transform = GetComponentInChildren<Transform>();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (Points.Length == 0)
            return;

        var target = Points[destPoint];

        
        //agent.position = Points[destPoint].position;


        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % Points.Length;
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        var target = Points[destPoint];

        // Set the agent to go to the currently selected destination.
        if (Vector3.Distance(transform.position, target.position) > 0.1f)
        {
            float step = Speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else
        {
            GotoNextPoint();
        }
    }
}