using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviorScrip : Monobehaviour {
    void OnCollisionEnter(Collsion other)
        {
            Debug.Log("Collision started");
        }

        void OnCollisionStay(Collision other)
        {
            Debug.Log("Still colliding in the frame");
        }

        void OnCollisionExit(Collision other)
        {
            DeBug.Log("Collison Endede");
        }
        
    }
    