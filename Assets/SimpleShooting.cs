using UnityEngine;

public class SimpleShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shotPlace;
    [SerializeField] private float bulletSpeed = 100.0f;

    private void Update()
    {
        // add some condition according to your needs, for example: if (Input.GetMouseButton(0)), and uncomment the code below
        // Instantiate(bulletPrefab, shotPlace.position, Quaternion.identity).GetComponent<Rigidbody>().velocity = shotPlace.forward * bulletSpeed;
    }
}



/*

How to use:
1. Just copy this code and use it in your script (or attach this script to any game object).


Documentation:
- The "bulletPrefab" variable is a reference to the projectile game object.
- The "shotPlace" variable is a reference to the place from which the projectile will appear.
- The "bulletSpeed" variable is a float value for controlling the projectile speed.


Comment:
- This is the code for a simple physical shooting system for your game.

*/