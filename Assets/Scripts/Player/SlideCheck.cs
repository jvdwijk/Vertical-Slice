using UnityEngine;
using System.Collections;

public class SlideCheck : MonoBehaviour {
	
	private Animator anim;
	private Movement movement;

	void Start () {
		anim = GetComponentInParent<Animator> ();
		movement = GetComponent<Movement> ();
	}
	
	void OnCollisionEnter2D (Collision2D other) 	
	{
		if(other.gameObject.CompareTag ("Slide"))
		{
			movement.enabled = false;
			anim.SetTrigger ("slide");
			anim.SetBool ("isSliding", true);
		}
	}

	void OnCollisionExit2D (Collision2D other) 	
	{
		if(other.gameObject.CompareTag ("Slide"))
		{
			movement.enabled = true;
			anim.SetBool ("isSliding", false);
		}
	}
}
