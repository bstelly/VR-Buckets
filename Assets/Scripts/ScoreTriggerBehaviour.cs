using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTriggerBehaviour : MonoBehaviour
{
    public Rigidbody BallRigidBody;
    public ScoreBoardBehaviour ScoreBoard;

    private Vector3 enteredVelocity;
    private Vector3 exitVelocity;
    private string lastPlayerContactOnBall;
    private bool enteredFromAbove;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            enteredVelocity = BallRigidBody.velocity;
            lastPlayerContactOnBall = other.GetComponent<GrabbedBehavior>().LastPlayerTag;
            if(other.transform.position.y > transform.position.y)
            {
                enteredFromAbove = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            exitVelocity = BallRigidBody.velocity;
        }
        if(enteredVelocity.y < 0 && exitVelocity.y < 0 && enteredFromAbove) //Ball was moving downwards when entering and exiting the trigger
        {
            enteredFromAbove = false;
            ScoreBoard.PlayerScored(lastPlayerContactOnBall);
            other.GetComponent<GrabbedBehavior>().LastPlayerTag = "";
        }
    }
}
