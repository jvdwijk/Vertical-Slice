using UnityEngine;
using System.Collections;

public class ColliderCheck : MonoBehaviour {

	public bool hanging;

	void OnTriggerEnter2D (Collider2D other) 	
	{
		if(other.gameObject.CompareTag ("rocks"))
		{
			Debug.Log ("test");
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
