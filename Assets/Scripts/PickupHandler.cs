using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isPickup = collision.gameObject.CompareTag("Pickup");

        if (isPickup == true)
        {
            collision.gameObject.SetActive(false);  
        } 
    }
}
