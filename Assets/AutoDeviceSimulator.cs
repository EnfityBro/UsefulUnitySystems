using UnityEngine;

namespace Enfity.UsefulUnitySystems
{
    public class AutoDeviceSimulator : MonoBehaviour
    {
        #if UNITY_EDITOR
            [SerializeField] private GameObject deviceSimulator;
            private static bool isInitialized;

            private void Awake()
            {
                if (!isInitialized)
                {
                    isInitialized = true;
                    DontDestroyOnLoad(Instantiate(deviceSimulator));
                }
            }
        #endif
    }
}



/*

How to use:
1. Copy this script into your project.
2. Attach this script to any game object.
3. In the 'deviceSimulator' field in the Inspector window, assign the 'XR Device Simulator' prefab from 'Samples/XR Interaction Toolkit/_YOUR_VERSION_/XR Device Simulator/' folder.


Comment:
- To use this script, check if the XR Interaction Toolkit with XR Device Simulator is installed in your project.
- This script automatically creates a XR Device Simulator object on your game scene only in Unity editor mode.
- This script designed for AR/MR/VR games.

*/