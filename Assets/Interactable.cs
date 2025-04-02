using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    public bool isKeyTriggered = true;

    void OnTriggerStay(Collider other)
    {
        // If a key needs to be pressed, make sure the player is near the
        // button and not some other random object.
        if (isKeyTriggered)
        {
            if ( Input.GetKeyDown(KeyCode.E)
              && other.tag == "Player"
               ) onInteract.Invoke();
        }

        // Otherwise, trigger the event.
        else onInteract.Invoke();
    }
}
