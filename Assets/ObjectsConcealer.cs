using UnityEngine;

namespace Enfity.UsefulUnitySystems
{
    public static class ObjectsConcealer
    {
    #if UNITY_6000_0_OR_NEWER
        /// <summary>
        /// Sets the rendering ability of a game object with a specified layer index.
        /// </summary>
        /// <remarks>
        /// Don't call this method in Update like methods.
        /// </remarks>
        public static void SetRenderingForGameObjectsByLayerIndex(bool isEnabled, int layerIndex, FindObjectsInactive findObjectsInactive = FindObjectsInactive.Exclude)
        {
            MeshRenderer[] allMeshRenderers = GameObject.FindObjectsByType<MeshRenderer>(findObjectsInactive, FindObjectsSortMode.None);

            foreach (MeshRenderer currentMeshRenderer in allMeshRenderers)
            {
                if (currentMeshRenderer.gameObject.layer == layerIndex)
                    currentMeshRenderer.enabled = isEnabled;
            }
        }
    #else
        /// <summary>
        /// Sets the rendering ability of a game object with a specified layer index.
        /// </summary>
        /// <remarks>
        /// Don't call this method in Update like methods.
        /// </remarks>
        public static void SetRenderingForGameObjectsByLayerIndex(bool isEnabled, int layerIndex)
        {
            MeshRenderer[] allMeshRenderers = GameObject.FindObjectsOfType<MeshRenderer>();

            foreach (MeshRenderer currentMeshRenderer in allMeshRenderers)
            {
                if (currentMeshRenderer.gameObject.layer == layerIndex)
                    currentMeshRenderer.enabled = isEnabled;
            }
        }
    #endif
    }
}



/*

How to use:
1. Copy this script into your project and call necessary methods.
2. Create a layer that will mark the objects whose rendering you want to manage using the SetRenderingForGameObjectsByLayerIndex method.


Comment:
- This method enable or disable all mesh renderers, when it called.
- This method is laborious and it's complexity is O(n), don't call it in Update or FixedUpdate base methods.
- This method can optimize your GPU resources and raise FPS, but requires CPU and memory resources when it called.

*/