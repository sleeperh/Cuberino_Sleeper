
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // holds player position when player game object is inserted
    public Vector3 offset; // offsets the camera position so that it doesn't look out of the center of the player game object


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
