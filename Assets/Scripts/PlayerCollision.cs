
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // reference to PlayerMovement script, dragged into this slot. 

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // disable player movement
            FindObjectOfType<GameManager>().EndGame();
           
        }
    }
}
