using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1, 10)]
    public float MovementSpeed = 4.0f;

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

        // override the old position with the new one
        transform.position = newPosition;
    }
}
