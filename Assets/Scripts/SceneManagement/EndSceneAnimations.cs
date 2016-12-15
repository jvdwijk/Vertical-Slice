using UnityEngine;
using System.Collections;

public class EndSceneAnimations : MonoBehaviour {

	private Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
		Invoke ("SetTrue", 1);
	}

	private void SetTrue()
	{
		anim.SetBool ("doneFirst", true);
	}

	public void Trigger()
	{
		anim.SetTrigger ("yes");
	}
}
