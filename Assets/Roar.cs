using UnityEngine;
using System.Collections;

public class Roar : MonoBehaviour
{
    private Animator anim;
	[SerializeField]
	private AudioSource roarSound;
   
   
    
    void Start()
    {
        anim = GetComponent<Animator>();
          
    }

    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Q))
            {
            anim.Play("Roar");
			roarSound.Play ();
        }
        
    }

}