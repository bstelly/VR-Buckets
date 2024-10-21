using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Grabber : MonoBehaviour
{
    public XRController Controller;
    public InputHelpers.Button Button;
    private bool buttonDown;

    private void Update()
    {
        Controller.inputDevice.IsPressed(Button, out buttonDown);
    }
}
