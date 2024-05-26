using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float gravityAccel;
    public Vector2 baseGravity;
    private Vector2 gravity;
    public float jumpCap;

    public Image jumpBar;

    public float xInput;
    public KeyCode jump;
    Rigidbody2D rb;

    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    bool groundCheck()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 0.55f, groundLayer);
    }

    public float jumpHeight = 0f;
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        if (rb.velocity.y < 0.1 && groundCheck()) {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKey(jump) && groundCheck()) {
            jumpHeight += Time.deltaTime;
            if (jumpHeight > jumpCap) {
                jumpHeight = jumpCap;
            }
        }
        if (Input.GetKeyUp(jump)) {
            rb.velocity = new Vector2(speed*xInput*jumpHeight, jumpHeight*jumpForce);
            jumpHeight = 0;
        }

        if (rb.velocity.y < 0) {
            gravity = baseGravity * gravityAccel;
        } else {
            gravity = baseGravity;
        }

        if (jumpBar.fillAmount != jumpHeight / jumpCap)
        {
            jumpBar.fillAmount = Mathf.Lerp(jumpBar.fillAmount, jumpHeight / jumpCap, 0.05f);
        }
        //rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }

    private void FixedUpdate() {
        rb.velocity += gravity;
    }
}