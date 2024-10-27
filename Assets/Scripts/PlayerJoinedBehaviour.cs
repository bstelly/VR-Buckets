using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoinedBehaviour : MonoBehaviour
{
    void Start()
    {
        var trackerObject = GameObject.FindGameObjectWithTag("PlayerTracker");
        trackerObject.GetComponent<PlayerTracking>().PlayerJoined(this);

        var left = GameObject.FindGameObjectWithTag("LeftGrabber");
        var right = GameObject.FindGameObjectWithTag("RightGrabber");
        left.GetComponent<SetObjectBeingGrabbed>().PlayerTag = this.gameObject.tag;
        right.GetComponent<SetObjectBeingGrabbed>().PlayerTag= this.gameObject.tag;

    }
}
