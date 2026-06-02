using UnityEngine;

public class SmoothMovementWithRotation : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed = 2.0f, rotationSpeed = 1.75f;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        Quaternion direction = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, direction, rotationSpeed * Time.deltaTime);
    }
}



/*

How to use:
1. Attach this script to a moving game object.
2. In the "target" field in the "Inspector" window, assign the target game object Transform.
3. Regulate the "moveSpeed" and "rotationSpeed" variables for your needs (you can also make these variables public).


Documentation:
- The "target" variable is the game object (or point) that the original game object object will move to.
- The "moveSpeed" variable is the movement speed of the original game object.
- The "rotationSpeed" variable is the rotation speed of the original game object.


Comment:
- This script allows you to create a flying game object form one point to another.
  The original game object also performs a smooth rotation to the target point.
- This approach ignores physical movement because movement is performed by "Vector3".

*/