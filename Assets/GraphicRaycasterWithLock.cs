using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Enfity.UsefulUnitySystems
{
    public class GraphicRaycasterWithLock : GraphicRaycaster
    {
        public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
        {
            if (Cursor.lockState == CursorLockMode.Locked)
                return;

            base.Raycast(eventData, resultAppendList);
        }
    }
}



/*

How to use:
1. Copy this script into your project.
2. Attach this script to World Space type Canvas instead of original GraphicRaycaster component.


Comment:
- Using this script instead of the standard GraphicRaycaster component on World Space type Canvases allows you to disable unnecessary mouse processing
  if it's disabled in the game. This is especially useful in VR games, where interaction takes place through the rays of the controllers.

*/