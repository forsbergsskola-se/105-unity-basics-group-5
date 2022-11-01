
using UnityEngine;

public class Driver : MonoBehaviour
{
    Vehicle [] vehicles;
    public float lengthAwayFromPlayer;
    
    private void Update()
    {
        if (EnterCarButtonPressed() && IsPlayerCloseEnough())
            vehicles[1].Enter();
    }
    
    bool EnterCarButtonPressed()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            vehicles = FindObjectsOfType<Vehicle>();
            //Debug.Log(vehicles.Length);
            return true;
        }

        return false;
    }
    
    bool IsPlayerCloseEnough()
    {
        if(Vector3.Distance(transform.position, vehicles[1].transform.position) < lengthAwayFromPlayer) 
            return true;
        return false;
    }
}
