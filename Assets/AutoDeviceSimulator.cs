using UnityEngine;

public class AutoDeviceSimulator : MonoBehaviour
{
    #if UNITY_EDITOR
    [SerializeField] private GameObject deviceSimulator;

    private void Awake()
    {
        if (GameObject.Find("XR Device Simulator(Clone)") == null)
        {
            DontDestroyOnLoad(Instantiate(deviceSimulator));
        }
    }
    #endif
}



/*

How to use:
1. Attach this script to any game object.
2. In the "deviceSimulator" field in the "Inspector" window, assign the "XR Device Simulator" prefab from "Samples/XR Interaction Toolkit/_YOUR_VERSION_/XR Device Simulator/" folder.


Documentation:
- The "deviceSimulator" variable is a reference to the "XR Device Simulator" prefab.


Comment:
- To use this script, check if the XR Interaction Toolkit with XR Device Simulator is installed in your project.
- This script automatically creates a XR Device Simulator object on your game scene only in Unity editor mode.
- This script designed for AR/MR/VR games.

*/