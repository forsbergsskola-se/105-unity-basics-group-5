using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {
    voud OnMouseDown() {
        Debug.Log("Click started");
    }

    void OnMouseDrag() {

        Debug.Log("I'm being dragged");
    }
    void OnMouseUp()
    {
        Debug.Log("Click ended");
    }

    void OnMouseEnter()
    {
        Debug.Log("Hover started");
    }

    void OnMouseExit()
    {
        Debug.Log("Hover ended");
    }
}
