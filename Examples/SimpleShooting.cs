using UnityEngine;

public class SimpleShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shotPlace;
    [SerializeField] private float bulletSpeed = 100.0f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bulletPrefab, shotPlace.position, Quaternion.identity).GetComponent<Rigidbody>().velocity = shotPlace.forward * bulletSpeed;
        }
    }
}



/*

How to use:
1. Just copy this code and use it in your script.
2. The bullet prefab must have a Rigidbody component.


Documentation:
- The 'bulletPrefab' field is a reference to the projectile game object.
- The 'shotPlace' field is a reference to the place from which the projectile will appear.
- The 'bulletSpeed' field is a float value for controlling the projectile speed.


Comment:
- This is the code for a simple physical shooting system for your game.

*/