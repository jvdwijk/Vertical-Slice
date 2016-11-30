using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	private float timer;
    public Renderer rend;
    public float movementSpeed = 10f;
    public Rigidbody2D rb;
    int random;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        random = Random.Range(1, 8);
    }

     void Update()
    {
   		Vector2 movement = new Vector2(1, 0.0f);
        rb.velocity = movement * movementSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            movementSpeed *= -1;           
        }
        else if (collision.gameObject.tag == "sukkel")
        {
            movementSpeed *= -1;
        }
    }
}
