using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

    public Movement movement;
	private ColliderCheck colliderCheck;

    void Start()
    {
		colliderCheck = GetComponentInChildren<ColliderCheck> ();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
        rb.gravityScale = 2.5f;
    }        

    void Update()
    {
        if (colliderCheck.hanging)
        {
			movement.enabled = false;
			rb.velocity = Vector3.zero;
			rb.gravityScale = 0;
			anim.SetBool ("isJumping", false);
            anim.SetBool("isSwinging", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumped();
                colliderCheck.hanging = false;
                rb.gravityScale = 2.5f;
				movement.enabled = true;
                anim.SetBool("isSwinging", false);
            }
        }
		if(!colliderCheck.hanging)
		{
			rb.gravityScale = 2.5f;
			movement.enabled = true;
			anim.SetBool("isSwinging", false);
		}
    }
}