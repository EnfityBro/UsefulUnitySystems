using UnityEngine;

public class NuclearOptimization : MonoBehaviour
{
    public static void NuclerOptimizationTool(bool isEnabled, int layerIndex)
    {
        GameObject[] meshObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject meshObject in meshObjects)
        {
            try
            {
                if (meshObject.layer == layerIndex) { meshObject.GetComponent<MeshRenderer>().enabled = isEnabled; }
            }
            catch (System.Exception) { }
        }
    }
}



/*

How to use:
1. Just copy the "NuclerOptimizationTool" method and use it in your script (or attach this script to any game object).
2. Create a layer that will mark the objects whose rendering you want to disable using this method.


Documentation:
- The "isEnabled" parameter is responsible for enabling/disabling rendering of objects with the selected layer.
- The "layerIndex" parameter is the index of the layer that marks the objects that will have rendering disabled.


Comment:
- This method is laborious and it's complexity is about O(n). This method disable all mesh renderers, when it called. This method can optimize your GPU resources and raise FPS, but requires more CPU and memory resources when it called.
- You can change this method as "private" instead of "public static" if you need to.

*/