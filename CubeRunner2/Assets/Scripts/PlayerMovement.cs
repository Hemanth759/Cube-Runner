using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float sideForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce (0f, 0f, force * Time.deltaTime);

        // To add force in left and right direction
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0f, 0f);
        }
    }
}
