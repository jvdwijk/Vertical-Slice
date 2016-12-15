using UnityEngine;
using System.Collections;

public class HangingCheck : MonoBehaviour {

	private bool hanging;
	public bool getSetHanging{
		get{return hanging;}
		set{hanging = value; }
	}

	void OnTriggerEnter2D (Collider2D other) 	
	{
		if(other.gameObject.CompareTag ("rocks"))
		{
			hanging = true;
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
