using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Time.deltaTime, 0f, 0f) ;
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0f, 0f, vertical * Time.deltaTime) ;
    }
}
