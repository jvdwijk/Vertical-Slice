using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public Renderer rend;
    public float movementSpeed = 10f;
    public Rigidbody rb;
    int random;
    private int pushDir = 10;
    private int pushBackSpeed = 1;

    void Start()
    {
        random = Random.Range(1, 8);
    }



    void Update()
    {



        Vector3 movement = new Vector3(1, 0.0f);

        rb.velocity = movement * movementSpeed;
    }
    void OnCollisionEnter(Collision collision)
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
