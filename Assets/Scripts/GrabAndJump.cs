using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

	private bool hanging = false;
    private Movement movement;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
        rb.gravityScale = 2.5f;
    }        

    void Update()
    {
        if (hanging)
        {
            anim.SetBool("isSwinging", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumped();
                hanging = false;
                rb.gravityScale = 2.5f;
				movement.enabled = true;
                anim.SetBool("isSwinging", false);
                anim.SetBool("isJumping", true);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("rocks"))
        {
			movement.enabled = false;
            hanging = true;
            rb.velocity = Vector3.zero;
            rb.gravityScale =0;
        }
    }
}