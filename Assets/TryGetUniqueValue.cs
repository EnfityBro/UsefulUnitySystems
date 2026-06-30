namespace Enfity.UsefulUnitySystems
{
    public static class TryGetUniqueValue
    {
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
}



/*

How to use:
1. Just copy this code into your project and call necessary methods.

*/