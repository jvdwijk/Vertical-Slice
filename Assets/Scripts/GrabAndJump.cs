using UnityEngine;
using System.Collections;

public class GrabAndJump : MonoBehaviour {

	private bool hanging = false;

	void Start () {
	
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.tag == "rocks")
		{
			hanging = true;
			if(Input.GetKeyUp (KeyCode.Space) )
			{

			}
		}
	}

	void OnKeyUp()
	{
		
	}
}
