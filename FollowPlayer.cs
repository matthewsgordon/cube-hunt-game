using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
// Player object
    public GameObject player;
    // Distance to Camera
    public float distanceFromPlayer = 10;
    // height of the camera from the player
    public float cameraHeight = 3;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Positions the camera at the same distance from the player at its current position 
        transform.position = player.transform.position - player.transform.forward * distanceFromPlayer;
        // Always point the camera in the same direction that the player is going 
        transform.LookAt(player.transform.position);
        // Postion the camera at a distance away from the player at the specidied camera height 
        transform.position = new Vector3(transform.position.x,transform.position.y + cameraHeight, transform.position.z);
    }
}
