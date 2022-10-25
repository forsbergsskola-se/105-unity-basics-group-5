using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0.01f, 0f, 0f);
        
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-0.01f, 0f, 0f);
    }
}
