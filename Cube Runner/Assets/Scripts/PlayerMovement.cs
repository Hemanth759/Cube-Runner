using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is reference to the rigidBody component called rb
	public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forword force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Movement functions here
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
