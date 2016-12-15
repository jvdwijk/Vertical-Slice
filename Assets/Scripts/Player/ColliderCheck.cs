using UnityEngine;
using System.Collections;

public class ColliderCheck : MonoBehaviour {

	public bool hanging;
	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D (Collider2D other) 	
	{
		if(other.gameObject.CompareTag ("rocks"))
		{
			hanging = true;
		}
	}

	void OnColliderEnter2D (Collision2D other) 	
	{
		if(other.gameObject.CompareTag ("slide"))
		{
			anim.SetTrigger ("slide");
		}
	}

	void OnTriggerExit2D (Collider2D other) 
	{
		if(other.gameObject.CompareTag ("rocks"))
		{
			hanging = false;
		}
	}
}
