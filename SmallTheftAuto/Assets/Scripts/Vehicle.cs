using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public CarMovement carMovement;

    public void Enter()
    {
        player.SetActive(false);
        carMovement.enabled = true;
    }

    public void Exit()
    {
        player.transform.position = transform.position;
        player.SetActive(true);
        carMovement.enabled = false;
    }
}
