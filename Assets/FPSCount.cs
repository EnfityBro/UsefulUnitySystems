using UnityEngine;

public class FPSCount : MonoBehaviour
{
    private int frameCounter = 0;
    private int fps = 0;
    private float timeCounter = 0.0f;

    private void Update()
    {
        FPSCounter(ref fps);
        // use the "fps" variable in some game logic further
    }

    private void FPSCounter(ref int fps)
    {
        frameCounter++;
        timeCounter += Time.deltaTime;

        if (timeCounter >= 1.0f)
        {
            timeCounter = 0.0f;
            fps = frameCounter;
            frameCounter = 0;
        }
    }
}



/*

How to use:
1. Just copy the "FPSCounter" method with the necessary variables and use it in your script (or attach this script to any game object).
2. The "FPSCounter" method should be called in "Update()".


Documentation:
- The "frameCounter" variable stores the current number of frames.
- The "fps" variable stores the current frames per second count.
- The "timeCounter" variable is just a time counter.
All variables values are updated every second.

*/