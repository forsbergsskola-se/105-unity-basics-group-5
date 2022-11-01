using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parkingspot : MonoBehaviour
{
    public GameObject parkingSpot;
    public GameObject carPrefab;
    public bool hasCar;
    
    void Start()
    {
        if(hasCar)
            Instantiate(carPrefab, parkingSpot.transform.position, Quaternion.identity);
    }
}
