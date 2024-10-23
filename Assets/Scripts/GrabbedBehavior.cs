using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbedBehavior : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    public XRBaseInteractor HandThatsGrabbing;
    public Velocity GrabbedVelocity;

    public void SetHandThatsGrabbing(XRBaseInteractor hand)
    {
        HandThatsGrabbing = hand;
    }
    public void ApplyForceOnRelease()
    {
        MyRigidbody.AddForce(GrabbedVelocity.GrabberVelocity, ForceMode.Impulse);
        HandThatsGrabbing = null;
    }
}
