using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	private bool playSound = false;
	[SerializeField]
	private AudioSource ratSound;

	void Start () {
	
	}

	void Update () {
		if (playSound == true) {
			Debug.Log ("afds");
			ratSound.Play ();
		}
	}

	void OnBecameVisible()
	{
		playSound = true;
	}
}
