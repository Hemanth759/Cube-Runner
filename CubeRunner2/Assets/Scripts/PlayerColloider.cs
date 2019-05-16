using UnityEngine;

public class PlayerColloider : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("we hit an obstacle");
        }
    }
}
