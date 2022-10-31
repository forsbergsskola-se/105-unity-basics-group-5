using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public CarMovement carMovement;

    public float lengthAwayFromPlayer;

    void Update()
    {
        if (EnterCarButtonPressed() )
        {
            if(PlayerIsInCar())
            {
                LeaveCar();
            }
            else
            {
                if(IsPlayerCloseEnough())
                    EnterCar();
            }
        }
    }
    
    bool EnterCarButtonPressed()
    {
        return Input.GetKeyDown(KeyCode.F);
    }
    
    bool PlayerIsInCar()
    {
        return !player.activeInHierarchy;
    }

    void EnterCar()
    {                
        player.SetActive(false);
        carMovement.enabled = true;
        
    }
    void LeaveCar()
    {
        player.transform.position = transform.position;
        player.SetActive(true);
        carMovement.enabled = false;
    }

    bool IsPlayerCloseEnough()
    {
        if(Vector3.Distance(player.transform.position, transform.position) < lengthAwayFromPlayer) 
            return true;
        return false;
    }
}
