using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour
{ 
	[SerializeField]
	protected bool grounded = true;
	[SerializeField]
	protected float jumpPower = 1750f;
    protected Rigidbody2D rb;
	protected Animator anim;
    [SerializeField]
    private Vector2 playerCurrentPosition;
    private Vector3 startCast;
    private Vector3 endCast;
	[SerializeField]
	private RaycastHit2D simbaJump;
	public bool getGrounded{
		get{ return grounded;}
	}

    void Start()
    {
		anim = GetComponent<Animator> ();
        rb = GetComponent<Rigidbody2D>();
        playerCurrentPosition = rb.transform.position;
        startCast = playerCurrentPosition;
        endCast = startCast;
        startCast.y -= 0.65f;
        endCast.y -= 0.05f;

    }

    void Update()
	{
        playerCurrentPosition = rb.transform.position;
        startCast = playerCurrentPosition;
        endCast = startCast;
        startCast.y -= 0.65f;
        endCast.y -= 0.75f;
        if (grounded == false)
        {
             
            simbaJump = Physics2D.Linecast(startCast, endCast);
			Debug.DrawLine (startCast, endCast);
			if (simbaJump.collider != null) {
				if (simbaJump.collider.tag == "Floor") {
					grounded = true;
					anim.SetBool ("isJumping", false);
				}
			}
			else if (!grounded && rb.velocity.y == 0)
			{
				grounded = true;
				anim.SetBool ("isJumping", false);
			}
        }
        else if (grounded && Input.GetButtonDown("Jump"))
        {
			Jumped ();
         }            
    }

	protected void Jumped()
	{
		anim.SetBool ("isJumping", true);
		grounded = false;
		rb.AddForce(transform.up * jumpPower);
	}
}