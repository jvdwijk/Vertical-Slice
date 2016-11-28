using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

	private bool hanging = false;
    private Movement movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
    }

        

    void Update()
    {
        if (hanging)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumped();
                hanging = false;
                rb.gravityScale = .5f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("rocks"))
        {
            Debug.Log("klfea");
            hanging = true;
            rb.velocity = Vector3.zero;
            rb.gravityScale = 0;
        }
    }
}
