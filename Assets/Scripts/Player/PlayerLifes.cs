using UnityEngine;
using System.Collections;

public class PlayerLifes : MonoBehaviour {
    [SerializeField]
    int lifes;
    bool GameOver;
	// Use this for initialization
	void Start () {
        lifes = 4;
        GameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            lifes--;
        }
	    if(lifes < 0 && GameOver == false)
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
