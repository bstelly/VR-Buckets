using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbedBehavior : MonoBehaviour
{
    public RealtimeTransform Realtime;
    public float VelocityMultiplier;
    public Rigidbody MyRigidbody;
    public XRBaseInteractor HandThatsGrabbing;
    public Velocity GrabbedVelocity;
    public Velocity CameraVelocity;
    public string LastPlayerTag;

    public void SetHandThatsGrabbing(XRBaseInteractor hand)
    {
        Realtime.ClearOwnership();
        Realtime.RequestOwnership();
        HandThatsGrabbing = hand;
    }
    public void ApplyForceOnRelease()
    {
        MyRigidbody.AddForce((GrabbedVelocity.GrabberVelocity - CameraVelocity.GrabberVelocity) * VelocityMultiplier, ForceMode.Impulse);
        HandThatsGrabbing = null;
    }
}
