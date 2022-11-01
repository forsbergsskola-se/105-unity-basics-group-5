using System;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public CarMovement carMovement;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    public void Enter()
    {
        player.SetActive(false);
        carMovement.enabled = true;
    }

    public void Exit()
    {
        player.SetActive(true);
        player.transform.position = transform.position;
        carMovement.enabled = false;
    }
}
