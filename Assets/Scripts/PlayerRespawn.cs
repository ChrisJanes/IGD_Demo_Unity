using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField]
    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
    }

    public void SetSpawnPosition(Vector3 newPosition)
    {
        spawnPosition = newPosition;
    }

    public void RespawnCharacter()
    {
        Debug.Log("Respawning Character to checkpoint");
        transform.position = spawnPosition;
    }
}
