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

	void OnCollisionEnter2D (Collider2D other) 	
	{
		Debug.Log ("appel");
		if(other.gameObject.CompareTag ("Slide"))
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
