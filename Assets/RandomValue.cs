namespace Enfity.UsefulUnitySystems
{
    public static class RandomValue
    {
        /// <summary>
        /// Tries to minimize duplication of a random int value from the range [minValue, maxValue).
        /// </summary>
        public static int TryGetUnique(ref int previousRandomValue, int minValue, int maxValue)
        {
            int currentRandomValue = UnityEngine.Random.Range(minValue, maxValue);

            if (currentRandomValue == previousRandomValue)
                currentRandomValue = UnityEngine.Random.Range(minValue, maxValue);

            previousRandomValue = currentRandomValue;
            return currentRandomValue;
        }
    }
}



/*

How to use:
1. Just copy this code into your project and call necessary methods.

*/