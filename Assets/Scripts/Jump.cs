using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour
{
    [SerializeField]
    private bool grounded = true;
    private float jumpPower = 190f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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