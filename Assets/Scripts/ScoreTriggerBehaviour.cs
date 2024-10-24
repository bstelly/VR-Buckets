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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            enteredVelocity = BallRigidBody.velocity;
            lastPlayerContactOnBall = other.GetComponent<GrabbedBehavior>().LastPlayerTag;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            exitVelocity = BallRigidBody.velocity;
        }
        if(enteredVelocity.y < 0 && exitVelocity.y < 0) //Ball was moving downwards when entering and exiting the trigger
        {
            ScoreBoard.PlayerScored(lastPlayerContactOnBall);
        }
    }
}
