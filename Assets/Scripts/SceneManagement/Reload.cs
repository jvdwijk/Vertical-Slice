using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {
	[SerializeField]
	private int scene;

	void Update () 
	{
		if(Input.GetKeyUp (KeyCode.R))
		{
			PlayerPrefs.SetInt ("lifes",PlayerPrefs.GetInt ("lifes") - 1);
			ChangeScene ();
		}
	}

	private void ChangeScene()
	{
		SceneManager.LoadScene(scene);
	}

}
