using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public float MeleeRange;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
       {
            RaycastHit2D rayHit = Physics2D.Raycast(transform.position, transform.right, MeleeRange, ~LayerMask.GetMask("Player"));
            //Debug.DrawRay(transform.position, transform.right, Color.red, 1.5f);

            if(rayHit.collider)
            {
                PickupSpawner pickup = rayHit.collider.GetComponent<PickupSpawner>();
                if(pickup)
                {
                    pickup.onMeleeHit();
                }
            }
       }
    }
}
