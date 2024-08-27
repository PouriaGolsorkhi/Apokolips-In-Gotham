using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ThePlayerMovement : MonoBehaviour
{
    public float Force = 200f;
    public Rigidbody rb;

    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, Force * Time.deltaTime, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -Force * Time.deltaTime, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if(transform.position.y <=-5.38 || transform.position.y >= 4.75)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, 0);
        }
    }
}
