using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPos;

    // Update is called once per frame
    void Update()
    {
        //take the transform of the player's position to update the camera postion to the player position
        this.gameObject.transform.position = new Vector3(playerPos.position.x + 5, playerPos.position.y, this.gameObject.transform.position.z);

    }
}
