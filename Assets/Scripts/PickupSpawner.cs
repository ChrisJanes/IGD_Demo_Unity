using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickupObject;
    
    public void onMeleeHit()
    {
        Instantiate(pickupObject, transform.position, transform.rotation);
        gameObject.SetActive(false);
    }
}
