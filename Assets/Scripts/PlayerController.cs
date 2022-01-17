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
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 newPosition 
            = new Vector3(
                transform.position.x + (horizontal * MovementSpeed * Time.deltaTime),
                transform.position.y + (vertical * MovementSpeed * Time.deltaTime), 
                0.0f);

        transform.position = newPosition;
    }
}
