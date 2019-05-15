using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce (0f, 0f, force * Time.deltaTime);
    }
}
