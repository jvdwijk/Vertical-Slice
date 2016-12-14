using UnityEngine;
using System.Collections;

public class Roll : MonoBehaviour {

	private Animator anim;
	private Movement movement;
	private Jump groundCheck;
	private ColliderCheck grab;
	private int direction;
	private int count = 0;

	void Start () {
		movement = GetComponent<Movement> ();
		groundCheck = GetComponent<Jump> ();
		grab = GetComponentInChildren<ColliderCheck> ();
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if(Input.GetKey (KeyCode.A) && Input.GetKeyDown (KeyCode.S) && !grab.hanging && groundCheck.getGrounded)
		{
			direction = -1;
			RollAway ();
		}
		else if(Input.GetKey (KeyCode.D) && Input.GetKeyDown (KeyCode.S) && !grab.hanging && groundCheck.getGrounded)
		{
			direction = 1;
			RollAway ();
		}
	}

	private void RollAway()
	{
		anim.SetTrigger ("rolled");
		movement.enabled = false;
		StartCoroutine (RollTime ());
	}

	private IEnumerator RollTime()
	{
		while(count < 12)
		{
			transform.Translate(10 * direction * Time.deltaTime,0,0);
			yield return new WaitForSeconds (0.05f);
			count++;
		}
		count = 0;
		ResetRoll ();
	}

	private void ResetRoll()
	{
		movement.enabled = true;
	}
}
