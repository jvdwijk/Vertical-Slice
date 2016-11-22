using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

	private bool hanging = false;


	void OnTriggerStay2D(Collider2D other)
	{
		if(other.CompareTag ("rocks"))
		{
			hanging = true;
			if(Input.GetKeyUp (KeyCode.Space) )
			{
				Jumped ();
			}
		}
	}
}
