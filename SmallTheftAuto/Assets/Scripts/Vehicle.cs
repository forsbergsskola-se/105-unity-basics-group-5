using System;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    private CarMovement carMovement;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
        carMovement = GetComponent<CarMovement>();
    }

    public void Enter()
    {
        Driver driver = player.GetComponent<Driver>();
        driver.gameObject.SetActive(false);
        carMovement.enabled = true;
    }

    public void Exit()
    {
        player.SetActive(true);
        player.transform.position = transform.position;
        carMovement.enabled = false;
    }
}