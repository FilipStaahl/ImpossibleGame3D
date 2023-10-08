using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.02f; // Field, not Var

    // Start is called before the first frame update
    void Start()
    {

    }
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
        }

        transform.Translate(0, 0, speed);
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.NameToLayer("Ground");
        Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
        return true;
    }
}
   
