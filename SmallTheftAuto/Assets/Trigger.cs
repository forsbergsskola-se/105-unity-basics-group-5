using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger overlap started");
    }
        void OnTriggerStay(Collider other)
        {
            Debug.Log("Still Overlapping Trigger in this Frame");
            
        }

        void OnTriggerExit(Collider other)
        {
            Debug.Log("Trigger Overlap ended");
        }   
}