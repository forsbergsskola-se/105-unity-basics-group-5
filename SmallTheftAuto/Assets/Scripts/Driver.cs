using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public Vehicle vehicle;
    public float lengthAwayFromPlayer;
    
    private void Update()
    {
        if (EnterCarButtonPressed() && IsPlayerCloseEnough())
            vehicle.Enter();
    }
    
    bool EnterCarButtonPressed()
    {
        return Input.GetButtonDown("Interact-Vehicle");
    }
    
    bool IsPlayerCloseEnough()
    {
        if(Vector3.Distance(transform.position, vehicle.transform.position) < lengthAwayFromPlayer) 
            return true;
        return false;
    }
}
