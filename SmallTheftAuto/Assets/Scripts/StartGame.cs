using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Update()
    {
        LoadGame();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("SanAndreas");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
