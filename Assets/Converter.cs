using UnityEngine;

namespace Enfity.UsefulUnitySystems
{
    public static class Converter
    {
        /// <summary>
        /// Converts a linear value (0-1) to logarithmic decibels (-80dB to 0dB).
        /// </summary>
        public static float LinearValueToDecibels(float value)
        {
            return (value > 0.01f) ? Mathf.Log10(Mathf.Clamp01(value)) * 20 : -80f;
        }

        /// <summary>
        /// Converts a Quaternion rotation to Euler angles in degrees, normalized to the range [-180, 180].
        /// </summary>
        public static Vector3 QuaternionRotationToDegreesAngle(Quaternion rotation)
        {
            Vector3 euler = rotation.eulerAngles;

            return new Vector3(
                euler.x > 180 ? euler.x - 360 : euler.x,
                euler.y > 180 ? euler.y - 360 : euler.y,
                euler.z > 180 ? euler.z - 360 : euler.z
            );
        }
    }
}



/*

How to use:
1. Just copy this script into your project and call necessary methods.

*/