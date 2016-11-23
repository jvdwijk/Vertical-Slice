using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public Renderer rend;
    public float movementSpeed = 10f;
    public Rigidbody2D rb;
    int random;
    private int pushDir = 10;
    private int pushBackSpeed = 1;

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
        if (collision.gameObject.tag == "wall1")
        {
            movementSpeed = -10f;

           Debug.Log("Collided");
           
        }
        else if(collision.gameObject.tag == "wall2")
            {
            movementSpeed = 10;
        }
    }
}
