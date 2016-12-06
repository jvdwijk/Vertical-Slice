using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour
{ 
    [SerializeField]
    private bool grounded = true;
	[SerializeField]
	protected float jumpPower = 1200f;
    protected Rigidbody2D rb;
	private Animator anim;

    void Start()
    {
		anim = GetComponent<Animator> ();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (grounded && Input.GetButtonDown("Jump"))
        {
			anim.SetBool ("isJumping", true);
			Jumped ();
         }            
         else if (!grounded && rb.velocity.y == 0)
         {
			anim.SetBool ("isJumping", false);
            grounded = true;
         }
    }

	protected void Jumped()
	{
		rb.AddForce(transform.up * jumpPower);
		grounded = false;
	}
}