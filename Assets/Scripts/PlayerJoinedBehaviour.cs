using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoinedBehaviour : MonoBehaviour
{
    public PlayerTracking PlayerTracker;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTracker.PlayerJoined(this);
    }
}
