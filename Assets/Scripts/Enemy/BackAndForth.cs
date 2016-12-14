using UnityEngine;
using System.Collections;

public class BackAndForth : MonoBehaviour
{
	private float timer;
	private Renderer rend;
	[SerializeField]
	private float movementSpeed = 10f;
	private Rigidbody2D rb;
    private int random;

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
    }
}
