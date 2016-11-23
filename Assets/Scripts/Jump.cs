using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour
{
    [SerializeField]
    private bool grounded = true;
    private float jumpPower = 190f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  

    void Update()
    {
            if (grounded && Input.GetButtonDown("Jump"))
            {
                rb.AddForce(transform.up * jumpPower);
                grounded = false;
            }            
            else if (!grounded && rb.velocity.y == 0)
            {
                grounded = true;
            }
    }
}

