using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    private Transform playerTRG;

    void Start()
    {
        playerTRG = PlayerController.instance.transform; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(playerTRG.position.x, playerTRG.position.y, transform.position.z);
    }
}
