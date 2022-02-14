using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private bool checkpointActive = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(checkpointActive == true)
        {
            PlayerRespawn RespawnObject = collision.gameObject.GetComponent<PlayerRespawn>();
            if(RespawnObject)
            {
                RespawnObject.SetSpawnPosition(transform.position);
                checkpointActive = false;
            }
        }
    }
}
