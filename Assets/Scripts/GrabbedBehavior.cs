using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbedBehavior : MonoBehaviour
{
    public float VelocityMultiplier;
    public Rigidbody MyRigidbody;
    public XRBaseInteractor HandThatsGrabbing;
    public Velocity GrabbedVelocity;
    public Velocity CameraVelocity;
    public string LastPlayerTag;

    public void SetHandThatsGrabbing(XRBaseInteractor hand)
    {
        HandThatsGrabbing = hand;
    }
    public void ApplyForceOnRelease()
    {
        MyRigidbody.AddForce((GrabbedVelocity.GrabberVelocity - CameraVelocity.GrabberVelocity) * VelocityMultiplier, ForceMode.Impulse);
        HandThatsGrabbing = null;
    }
}
