using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        if ((target.gameObject != null) && target.gameObject.activeSelf)
        {
            transform.position = target.position;
            transform.rotation = target.rotation;
        }
    }
}



/*

How to use:
1. Attach this script to the game object that follows the target game object.


Documentation:
- The "target" is the object that the original game object will follow.


Comment:
- If you're sure about the target game object (that it's active and on scene all the time), you can remove the "if()" construct for more efficiency.
- You can modify this script for your needs.

*/