using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerVibration : MonoBehaviour
{
    private InputDevice leftController;
    private InputDevice rightController;

    private void Start()
    {
        // lists with all connected devices
        List<InputDevice> leftControllers = new List<InputDevice>();
        List<InputDevice> rightControllers = new List<InputDevice>();

        // put all left/right controllers in the left/right Controllers list
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller, leftControllers);
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller, rightControllers);

        if (leftControllers.Count > 0) { leftController = leftControllers[0]; }
        if (rightControllers.Count > 0) { rightController = rightControllers[0]; }
    }

    public void SetControllerVibration(float intensity, float duration)
    {
        leftController.SendHapticImpulse(0, Mathf.Clamp01(intensity), Mathf.Clamp01(duration));
        rightController.SendHapticImpulse(0, Mathf.Clamp01(intensity), Mathf.Clamp01(duration));
    }
}



/*

How to use:
1. Just copy this code and use it in your script (or attach this script to any game object).
2. Call the "SetControllerVibration" method to set the vibration for both controllers with selected intensity and duration.


Documantation:
- The "leftController" variable contains information about the connected left controller.
- The "rightController" variable contains information about the connected right controller.
- The "intensity" parameter is responsible for vibration intensity (must be in range [0, 1]).
- The "duration" parameter is responsible for vibration duration (must be in range [0, 1]).


Comment:
- You can modify this script to set the vibration for the left and right controllers separately.
- This script has been tested on Oculus Quest 2 and Meta Quest 3 VR controllers.

*/