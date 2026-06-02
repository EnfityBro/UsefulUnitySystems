using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableExtra : XRGrabInteractable
{
    protected override void Grab()
    {
        base.Grab();

        // do something when the object has been grabbed
    }

    protected override void Drop()
    {
        base.Drop();

        // do something when the object has been dropped
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        // do something when the player hovers the VR controller's ray at the game object

        // use "args.interactorObject" to get information about which VR controller's ray is hovered at the game object
        // use "args.interactableObject" to interact with the hovered object
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        // do something when the player moves the VR controller's ray away from the game object

        // use "args.interactorObject" to get information about which VR controller's ray is hovered at the game object
        // use "args.interactableObject" to interact with the hovered object
    }
}



/*

How to use:
1. Use this override logic in your script inherited from the XRGrabInteractable class.
2. Your script should be used instead of the original "XR Grab Interactable" component on a game object that can be grabbed by the player.


Comment:
- To use this script, check if the XR Interaction Toolkit is installed in your project.

*/