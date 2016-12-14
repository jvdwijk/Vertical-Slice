using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    private bool facingRight;
    [SerializeField]
    private float speed = 5;
    private Rigidbody2D rb;
	private Animator anim;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
        facingRight = true;
	}
	
	// Update is called once per frame
    void FixedUpdate () {
		if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
		{
			anim.SetBool ("isRunning", false);
		}
        if (Input.GetKey(KeyCode.D))
        {

			anim.SetBool ("isRunning", true);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
			anim.SetBool ("isRunning", true);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D) && facingRight == false)
        {
            Flip();
            facingRight = true;
        }
        if(Input.GetKey(KeyCode.A) && facingRight == true)
        {
            Flip();
            facingRight = false;
        }
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
