using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace Enfity.UsefulUnitySystems
{
    public class ARRaycastAimController : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private GameObject target;

        [Header("Components")]
        [SerializeField] private Camera arCamera;
        [SerializeField] private ARRaycastManager raycastManager;
        [SerializeField] private ARPlaneManager planeManager;

        private ARPlane currentPlane;
        private List<ARRaycastHit> resultsOfHits;

        private void Awake()
        {
            currentPlane = null;
            resultsOfHits = new List<ARRaycastHit>();
        }

        private void Update()
        {
            if (target != null)
            {
                Vector3 centerOfScreen = arCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f, 0));
                raycastManager.Raycast(centerOfScreen, resultsOfHits, TrackableType.PlaneWithinBounds);

                try
                {
                    ARRaycastHit? hit = resultsOfHits[0];
                    currentPlane = planeManager.GetPlane(hit.Value.trackableId);

                    target.transform.position = hit.Value.pose.position;
                    target.transform.rotation = Quaternion.Euler(0, arCamera.transform.rotation.eulerAngles.y, 0);
                }
                catch (System.Exception) { }

                target.SetActive(currentPlane != null);
            }
        }
    }
}



/*

How to use:
1. Copy this script into your project.
2. Attach this script to any game object (or empty game object).
3. In the 'target' field in the Inspector window, assign the target game object (aim).
4. In the 'arCamera' field in the Inspector window, assign the camera which uses AR.
5. In the 'raycastManager' field in the Inspector window, assign the active ARRaycastManager component on the scene
   (it usually located at the 'XR Origin (Mobile AR)' game object).
6. In the 'planeManager' field in the Inspector window, assign the active ARPlaneManager component on the scene
   (it usually located at the 'XR Origin (Mobile AR)' game object).


Comment:
- This script allows you to control the game object attached to the scanned plane through the movements of the device.
- To use this script, check if AR Foundation, Google ARCore XR Plugin, OpenXR Plugin and XR Interaction Toolkit packages are installed in your project.
- This script designed for AR games only.

*/