using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Brick : MonoBehaviour
{
    void Start()
    {
        Debug.Log("game started.");
        Debug.Log("offsetting brick placements...");
        transform.position += transform.right * Random.Range(-.2f, .2f);
    }
}
