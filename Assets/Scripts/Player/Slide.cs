using UnityEngine;
using System.Collections;

public class Slide : MonoBehaviour {

	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2d(Collider2D other)
	{
		if(other.CompareTag ("Slide"))
		{
			anim.SetBool ("isSliding", true);
		}

	}
}
