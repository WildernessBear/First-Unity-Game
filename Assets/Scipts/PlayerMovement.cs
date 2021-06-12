using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the RigidBody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // use FixedUpdate when calculating physics
    void FixedUpdate()
    {
        // add a forward force
        // deltaTime is used to keep speed 
        // constant no mater the frame rate
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // move left
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // move right
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // end game if player falls off ground
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
