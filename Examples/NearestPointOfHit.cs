using UnityEngine;

public class NearestPointOfHit : MonoBehaviour
{
    // Trigger with trigger, trigger with collider
    /*
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.ClosestPoint(transform.position));
    }
    */

    // Collider with collider
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.contacts[0].point);
    }
    */
}



/*

How to use:
1. Just copy the required method into your script.


Comment:
- This is how to track the contact point when one object hits another object.

*/