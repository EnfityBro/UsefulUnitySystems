using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public static class ControllerVibration
{
    private static InputDevice leftController;
    private static InputDevice rightController;

    static ControllerVibration()
    {
        InitializeControllers();
    }

    [Flags]
    public enum ControllersInfo
    {
        None = 0,
        Left = 1 << 0,
        Right = 1 << 1,
        Both = Left | Right
    }

    /// <summary>
    /// Initializing connected controllers.
    /// </summary>
    /// <remarks>
    /// Call this method only when connecting or reconnecting controllers during the game.
    /// </remarks>
    public static void InitializeControllers()
    {
        // lists with all connected devices
        List<InputDevice> leftControllers = new List<InputDevice>();
        List<InputDevice> rightControllers = new List<InputDevice>();

        // put all left/right controllers in the left/right Controllers list
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller, leftControllers);
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller, rightControllers);

        if (leftControllers.Count > 0)
            leftController = leftControllers[0];
        if (rightControllers.Count > 0)
            rightController = rightControllers[0];
    }

    /// <summary>
    /// Sets the vibration to a preset intensity and duration for the selected controllers.
    /// </summary>
    /// <remarks>
    /// The parameters 'intensity' and 'duration' should be in range [0, 1].
    /// </remarks>
    public static void SetControllerVibration(float intensity, float duration, ControllersInfo controllersInfo)
    {
        if (controllersInfo.HasFlag(ControllersInfo.Left) && (leftController != null))
            leftController.SendHapticImpulse(0, Mathf.Clamp01(intensity), Mathf.Clamp01(duration));

        if (controllersInfo.HasFlag(ControllersInfo.Right) && (rightController != null))
            rightController.SendHapticImpulse(0, Mathf.Clamp01(intensity), Mathf.Clamp01(duration));
    }
}



/*

How to use:
1. Just copy this script into your project and call necessary methods.


Comment:
- This script has been tested on Oculus Quest 2 and Meta Quest 3 VR controllers.

*/