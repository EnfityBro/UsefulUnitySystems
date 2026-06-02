using UnityEngine;

public class ForUI
{
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    /// <summary>
    /// Mouse cursor disabling only in game build for VR games.
    /// </summary>
    /// <remarks>
    /// It can be called from Awake() or Start().
    /// </remarks>
    private void MouseCursorDisabling()
    {
        #if UNITY_EDITOR
        #else
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        #endif
    }

    public static void SetActiveMouseCursor(bool isActive)
    {
        Cursor.lockState = isActive ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = isActive;
    }
}



/*

How to use:
1. Just copy the required method into your script.

*/