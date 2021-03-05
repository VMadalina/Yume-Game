using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CodeYume : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;
    Animator a;
    bool ground = false, jumped;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask WhatIsGround;
    public float jumpForce = 700f;

    void Start ()
    {
        a = GetComponent<Animator>();
    }
	
	void FixedUpdate () //run & flip
    {
       ground = Physics2D.OverlapCircle(groundCheck.position, groundRadius, WhatIsGround);
        a.SetBool("Ground", ground);
        a.SetFloat("verticalSpeed", GetComponent<Rigidbody2D>().velocity.y);

        float move = Input.GetAxis("Horizontal");
        a.SetFloat("Speed", Mathf.Abs(move));
        GetComponent< Rigidbody2D >(). velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
	}

    void Update()
    {
        if (ground )
        {
            jumped = false;
        }

        if (ground && Input.GetKeyDown(KeyCode.Space)) //jump
            {
            a.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
             }

        if (Input .GetKeyDown (KeyCode .Space ) && !jumped && !ground )//double jump
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce/2));
            jumped = true;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theSacale = transform.localScale;
        theSacale.x *= -1;
        transform.localScale = theSacale;
    }
}
