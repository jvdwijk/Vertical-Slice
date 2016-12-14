using UnityEngine;
using System.Collections;

public class Roar : MonoBehaviour
{
    private Animator anim;
   
   
    
    void Start()
    {
        anim = GetComponent<Animator>();
          
    }

    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Q))
            {
            anim.Play("Roar");

        }
        
    }

}