using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public float xInput;
    Rigidbody2D rb;

    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    bool groundCheck()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, 0.55f, groundLayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        if (groundCheck())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }
}