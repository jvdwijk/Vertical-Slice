using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {

    [SerializeField]
    private float jumpPower = 500;
    private Rigidbody2D rb;
    private bool visible = true;


	void Start () {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(JumpTime());
	}
	
	void Jump () {
        rb.AddForce(transform.up * jumpPower);
        Debug.Log("whooped");
    }

    /*void OnBecameInvisible()
    {
        DestroyObject(this.gameObject);
        visible = false;    
    }    */

        


    IEnumerator JumpTime()
    {
        float minWaitTime = 2;
        float maxWaitTime = 5;

        while (visible == true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            Jump();

        }

    }
}
