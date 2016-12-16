using UnityEngine;
using System.Collections;

public class PlayerLifes : MonoBehaviour {
    [SerializeField]
    int lifes;
    bool GameOver;
	// Use this for initialization
	void Start () {
        lifes = 4;
		if(!PlayerPrefs.HasKey ("lifes"))
		{
			PlayerPrefs.SetInt ("lifes",lifes);
		}
		lifes = PlayerPrefs.GetInt ("lifes");
        GameOver = false;
	}

	void Update () {
	    if(lifes <= 0 && GameOver == false)
        {
            GameOver = true;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("1up"))
        {
            lifes++;
			Destroy (other.gameObject); 
    
        }
    }
}
