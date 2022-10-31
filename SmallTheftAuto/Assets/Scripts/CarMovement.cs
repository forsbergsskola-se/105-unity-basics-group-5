
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Vehicle vehicle;
    public GameObject player;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Time.deltaTime, 0f, 0f) ;
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0f, 0f, vertical * Time.deltaTime) ;

        if (Input.GetButtonDown("Interact-Vehicle"))
            if (PlayerIsInCar()) 
                vehicle.Exit();

    }
    bool PlayerIsInCar()
    {
        return !player.activeInHierarchy;
    }
}
