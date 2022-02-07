using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1, 10)]
    public float MovementSpeed = 4.0f;

    public Animator animator; 

    // Get player input and move the attached game object
    void Update()
    {
        // local variables that only exist inside Update
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // create a new Vector3 that stores the updated position
        Vector3 newPosition 
            = new Vector3(
                transform.position.x + (horizontal * MovementSpeed * Time.deltaTime),
                transform.position.y + (vertical * MovementSpeed * Time.deltaTime), 
                0.0f);

        // set animation parameter to transition to / from idle and walk
        float moveSpeed = Vector3.Distance(newPosition, transform.position);
        animator.SetFloat("MovementSpeed", moveSpeed);

        // override the old position with the new one
        transform.position = newPosition;

        // moving right
        if(horizontal > 0.0f)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        } 
        else if( horizontal < 0.0f)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
        }
        else if (vertical > 0.0f)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
        }
        else if (vertical < 0.0f)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);
        }
    }
}
