using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public PlayerMovement movement;

    // function for the collision of the player object
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
