using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

	private bool hanging = false;

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
        if(other.transform.tag == "rocks")
        {
            hanging = true;
            rb.velocity = Vector3.zero;
            rb.gravityScale = 0;
        }
    }
}
