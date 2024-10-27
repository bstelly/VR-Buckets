using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetObjectBeingGrabbed : MonoBehaviour
{
    public string PlayerTag;
    public XRBaseInteractor Interactor;
    public Velocity MyVelocity;
    public GameObject CurrentlyGrabbedObject;

    public void SetCurrentlyGrabbedObject()
    {
        CurrentlyGrabbedObject = Interactor.interactablesSelected[0].transform.gameObject;
        var grabbedBehaviour = CurrentlyGrabbedObject.GetComponent<GrabbedBehavior>();
        grabbedBehaviour.GrabbedVelocity = MyVelocity;
        grabbedBehaviour.HandThatsGrabbing = Interactor;
        grabbedBehaviour.Realtime.ClearOwnership();
        grabbedBehaviour.Realtime.RequestOwnership();
        grabbedBehaviour.LastPlayerTag = PlayerTag;
    }
    public void UnSetCurrentlyGrabbedObject()
    {
        CurrentlyGrabbedObject = null;
    }
}
