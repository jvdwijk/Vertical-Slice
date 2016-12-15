using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

    public Movement movement;
	private HangingCheck hangingCheck;

	void Start()
    {
		hangingCheck = GetComponentInChildren<HangingCheck> ();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
        rb.gravityScale = 2.5f;
    }        

    void Update()
    {
		if (hangingCheck.getSetHanging)
        {
			movement.enabled = false;
			rb.velocity = Vector3.zero;
			rb.gravityScale = 0;
			anim.SetBool ("isJumping", false);
            anim.SetBool("isSwinging", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumped();
				hangingCheck.getSetHanging = false;
                rb.gravityScale = 2.5f;
				movement.enabled = true;
                anim.SetBool("isSwinging", false);
            }
        }
		if(!hangingCheck.getSetHanging && !anim.GetBool ("isSliding"))
		{
			rb.gravityScale = 2.5f;
			movement.enabled = true;
			anim.SetBool("isSwinging", false);
		}
    }
}