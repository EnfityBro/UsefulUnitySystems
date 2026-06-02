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
        // do something when the player hovers the VR controller's ray at a game object
        // use "args.interactorObject" to interact with the hovered object
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        // do something when the player moves the VR controller's ray away from the game object
        // use "args.interactorObject" to interact with the hovered object
    }
}



/*

How to use:
1. Use this script instead of the original "XR Grab Interactable" component (attach this script to a game object that can be grabbed by the player).


Comment:
- To use this script, check if the XR Interaction Toolkit is installed in your project.

*/