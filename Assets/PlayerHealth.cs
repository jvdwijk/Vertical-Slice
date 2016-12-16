using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
/*    */
//public Sprite i;
    public float health = 6;

    void Update()
    {
        if (health <= 0)
        {
            levelReset();
        }
      
    }
    void levelReset()
    {
		PlayerPrefs.SetInt ("lifes",PlayerPrefs.GetInt ("lifes") - 1);
        SceneManager.LoadScene(1);
    }

   /* void OnTriggerEnter2D(Collider2D other)
    {
		if (other.transform.tag == "sukkel" || other.gameObject.CompareTag ("enemy"))
        {
			Destroy (other.gameObject);
        }
    }*/
}

