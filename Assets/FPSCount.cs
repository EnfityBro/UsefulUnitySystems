using UnityEngine;

public class FPSCount : MonoBehaviour
{
    private int frameCounter = 0;
    private int fps = 0;
    private float timeCounter = 0.0f;

    private void Update()
    {
        FPSCounter(ref fps);
        // use the fps field's value further
    }

    /// <summary>
    /// Counts the number of frames per second and writes the result in an int field.
    /// </summary>
    /// <remarks>
    /// Should be called in Update base method.
    /// </remarks>
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
1. Just copy the FPSCounter method with the necessary fields and use it in your script.
2. The FPSCounter method should be called in Update base method.


Documentation:
- The frameCounter field stores the current number of frames.
- The fps field stores the current frames per second count.
- The timeCounter field is just a time counter.

*/