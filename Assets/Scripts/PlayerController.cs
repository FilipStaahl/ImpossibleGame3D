using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.02f; // Field, not Var
    
    
    private void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody.velocity.y < -.1f)
        {
            rigidbody.AddForce(0, -10, 0);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 300, 0);
            rigidbody.angularVelocity = new Vector3(2, 0, 0);
        }

        transform.Translate(0, 0, speed, Space.World );
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}
   
