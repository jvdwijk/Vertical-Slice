using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public Sprite i;
    public float health = 300;

    void Update()
    {
        if (health <= 0)
        {
            levelReset();
        }
      
    }
    void levelReset()
    {
        SceneManager.LoadScene("Djanco");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "sukkel")
        {
            
            health -= 100;
        }
    }
}

