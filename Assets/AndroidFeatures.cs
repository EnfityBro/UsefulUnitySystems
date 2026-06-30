using UnityEngine;

namespace Enfity.UsefulUnitySystems
{
    public static class AndroidFeatures
    {
        public enum ToastLength
        {
            Short,
            Long
        }

        /// <summary>
        /// Shows a toast message of the specified length.
        /// </summary>
        public static void ShowToast(string message, ToastLength toastLength)
        {
            #if UNITY_ANDROID && (!UNITY_EDITOR)
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");

                int length = toastLength == ToastLength.Short
                    ? toastClass.GetStatic<int>("LENGTH_SHORT")
                    : toastClass.GetStatic<int>("LENGTH_LONG");

                currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
                {
                    AndroidJavaObject toastObject = toastClass.CallStatic<AndroidJavaObject>("makeText", currentActivity, message, length);
                    toastObject.Call("show");
                }));
            #else
                Debug.Log($"Toast message: {message}, toast length = {toastLength}");
            #endif
        }
    }
}



/*

How to use:
1. Just copy this script into your project and call necessary methods.


Comment:
- Your project must be on the Android platform.

*/