using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W)) 
            transform.Translate(0f, 0f, 1f * Time.deltaTime) ;
        if (Input.GetKey(KeyCode.S)) 
            transform.Translate(0f, 0f, -1f * Time.deltaTime) ;
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-1f * Time.deltaTime, 0f, 0f ) ;
        if (Input.GetKey(KeyCode.D))
            transform.Translate(1f * Time.deltaTime, 0f, 0f) ;
        */
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Time.deltaTime, 0f, 0f) ;
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0f, 0f, vertical * Time.deltaTime) ;
        
        


    }
}
