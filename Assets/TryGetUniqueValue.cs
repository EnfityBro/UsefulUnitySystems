using UnityEngine;

public class TryGetUniqueValue : MonoBehaviour
{
    private int previousRandomValue = -1;

    /// <summary>
    /// Tries to minimize duplication of a random int value from the range [minValue, maxValue).
    /// </summary>
    public static int TryGetUniqueRandomValue(ref int previousRandomValue, int minValue, int maxValue)
    {
        int currentRandomValue = UnityEngine.Random.Range(minValue, maxValue);

        if (currentRandomValue != previousRandomValue)
        {
            previousRandomValue = currentRandomValue;
            return currentRandomValue;
        }
        else
        {
            currentRandomValue = UnityEngine.Random.Range(minValue, maxValue);
            previousRandomValue = currentRandomValue;
            return currentRandomValue;
        }
    }
}



/*

How to use:
1. Just copy the "TryGetUniqueRandomValue" method and use it in your script (or attach this script to any game object).


Documentation:
- The "previousRandomValue" parameter is a reference to the previous random value. This variable controls the duplication.
- The "minValue" parameter is the minimum value from a random range. This value is included in the range.
- The "maxValue" parameter is the maximum value from a random range. This value is excluded from the range.


Comment:
- This method tries to minimize duplication of a random int value from the range [minValue, maxValue).

*/