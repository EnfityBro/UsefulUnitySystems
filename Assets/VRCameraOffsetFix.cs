using System.Collections;
using UnityEngine;

public class VRCameraOffsetFix : MonoBehaviour
{
    private void Start() => StartCoroutine(CameraOffsetDelay());

    private IEnumerator CameraOffsetDelay()
    {
        yield return new WaitForSeconds(0.15f);

        transform.localPosition = new Vector3(0, PlayerPrefs.GetFloat("VRCameraOffsetValue"), 0);

        yield break;
    }
}



/*

How to use:
1. Select the "Not Specified" parameter in the "Tracking Origin Mode" field in the "XR Origin" component of the "XR Origin Rig" object.
2. Set the "Camera Y Offset" parameter to 0 in the "XR Origin" component of the "XR Origin Rig" object.
3. Attach this script to "Camera Offset" object in your "XR Origin Rig".
4. Set the Y position to 0 for the "Camera Offset".
5. Set the Y position to 0 for the "Main Camera".
7. Manage the "PlayerPrefs.GetFloat("VRCameraOffsetValue")" value from another script (for example, from the game settings script).


Comment:
- Instead of PlayerPrefs you can use another save/load system or use your fixed value.
- This script allows you to quickly solve the problem with the incorrect VR camera offset in the game build.
  This problem was noticed on Oculus Quest 2 due to incorrect settings of the play zone.
  This script will be useless if you select other settings of the "Tracking Origin Mode" field,
  set the play zone in VR headset correctly,
  or select "Character Controller Driver" for camera offset controlling.

*/