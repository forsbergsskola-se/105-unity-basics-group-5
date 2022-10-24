using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour {
    void OnApplicationQuit()
    {
        Debug.Log("Called when you quit the game.");
    }

    void OnApplicationPause(bool pauseStatus) {
        Debug.Log("Called when pausing(true)" +
                  "or un-pausing (false) the game");
    }

    void OnValidate()
    {
        Debug.Log("Called on game start and whenever" +
                  "a value is changes in the inspector." +
                  "Great for validating the input");
    }
    
}
