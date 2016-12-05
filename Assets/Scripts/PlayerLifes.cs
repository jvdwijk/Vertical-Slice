using UnityEngine;
using System.Collections;

public class PlayerLifes : MonoBehaviour {
    [SerializeField]
    private GameObject DeathScreen;
    [SerializeField]
    int lifes;
    bool GameOver;
	// Use this for initialization
	void Start () {
        lifes = 4;
        GameOver = false;
        DeathScreen.SetActive(false);
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
            DeathScreen.SetActive(true);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OneUp"))
        {
            Debug.Log("wat een mooie muts");
            lifes++;
            GameObject.DestroyImmediate(this);
    
        }
    }
}
