using UnityEngine;

public class ForMenus : MonoBehaviour
{
    public void ReloadCurrentScene() => UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // mouse cursor disabling only in game build, it can be called from Awake() or Start() (for VR games)
    private void MouseCursorDisabling()
    {
        #if UNITY_EDITOR
        #else
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        #endif
    }
}



/*

How to use:
1. Just copy the required method into your script.

*/