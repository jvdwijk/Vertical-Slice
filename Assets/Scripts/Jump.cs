using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour
{ 
    [SerializeField]
    private bool grounded = true;
	[SerializeField]
	protected float jumpPower = 1750f;
    protected Rigidbody2D rb;
	private Animator anim;
    [SerializeField]
    private Vector2 playerCurrentPosition;
    private Vector3 startCast;
    private Vector3 endCast;

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
        Debug.DrawLine(startCast, endCast, Color.red);
        playerCurrentPosition = rb.transform.position;
        startCast = playerCurrentPosition;
        endCast = startCast;
        startCast.y -= 0.65f;
        endCast.y -= 0.75f;
        Debug.Log(rb.transform.position);
        if (grounded == false)
        {
             
            RaycastHit2D simbaJump = Physics2D.Linecast(startCast, endCast);
            if (simbaJump.collider.tag == "Floor")
            {
                grounded = true;
                anim.SetBool("isJumping", false);
            }
        }
        if (grounded && Input.GetButtonDown("Jump"))
        {
			anim.SetBool ("isJumping", true);
			Jumped ();
         }            
       /*  else if (!grounded && rb.velocity.y == 0)
         {
            grounded = true;
         }*/
    }

	protected void Jumped()
	{
		rb.AddForce(transform.up * jumpPower);
		grounded = false;
	}
}