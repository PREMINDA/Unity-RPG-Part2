using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    private Transform playerTRG;
    public Tilemap map;

    private Vector3 bottomLeft;
    private Vector3 topRight;
    private float halfHeight;
    private float halfWidth;

    void Start()
    {
        playerTRG = PlayerController.instance.transform;

        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;

        bottomLeft = map.localBounds.min + new Vector3(halfWidth, halfHeight, 0f); 
        topRight = map.localBounds.max + new Vector3(-halfWidth, -halfHeight, 0f);

        PlayerController.instance.playerLimit(map.localBounds.min, map.localBounds.max);

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(playerTRG.position.x, playerTRG.position.y, transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeft.x, topRight.x), Mathf.Clamp(transform.position.y, bottomLeft.y, topRight.y), transform.position.z);

    }
}
