using UnityEngine;
using System.Collections;

public class Hands : GrabAndJump {

	// Use this for initialization
	void Start () {
	//hoer
	}
	
	
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("rocks"))
        {
            movement.enabled = false;
          //  hanging = true;
            rb.velocity = Vector3.zero;
            rb.gravityScale = 0;
        }
    }
}
