using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private int speed = 5;
    private Rigidbody2D rb;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
