using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float VelocityMultiplier;
    public Vector3 GrabberVelocity;
    
    private Vector3 lastFramePosition;

    private void LateUpdate()
    {
        GrabberVelocity = (transform.position - lastFramePosition) * VelocityMultiplier;
        lastFramePosition = transform.position;
    }
}
