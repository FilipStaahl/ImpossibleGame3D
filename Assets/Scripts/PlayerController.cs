using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.02f; // Field, not Var
    
    
    public void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;
        if (rigidbody.velocity.y < -.1f)
        {
            rigidbody.AddForce(0, -10, 0);
        }

        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, speed);
    }

    // Update is called once per frame
    public void Update()
    {
        float jumpForce = 200;
        if (Input.GetButton("Jump") && IsTouchingGround())
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            Vector3 velocity = rigidbody.velocity;
            velocity.y = jumpForce;
            rigidbody.AddForce(0, jumpForce, 0);
            rigidbody.angularVelocity = new Vector3(2, 0, 0);
        }
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}
   
