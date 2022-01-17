using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandler : MonoBehaviour
{
    // handle player v pickup interactions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // only work with objects tagged with "Pickup"
        bool isPickup = collision.gameObject.CompareTag("Pickup");

        if (isPickup == true)
        {
            // disable the Pickup item rather than destroying it.
            collision.gameObject.SetActive(false);  
        } 
    }
}
