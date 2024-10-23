using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetObjectBeingGrabbed : MonoBehaviour
{
    public XRBaseInteractor Interactor;
    public Velocity MyVelocity;
    public GameObject CurrentlyGrabbedObject;

    public void SetCurrentlyGrabbedObject()
    {
        CurrentlyGrabbedObject = Interactor.interactablesSelected[0].transform.gameObject;
        var grabbedBehaviour = CurrentlyGrabbedObject.GetComponent<GrabbedBehavior>();
        grabbedBehaviour.GrabbedVelocity = MyVelocity;
        grabbedBehaviour.HandThatsGrabbing = Interactor;
    }
    public void UnSetCurrentlyGrabbedObject()
    {
        CurrentlyGrabbedObject = null;
    }
}
