using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject mainMenu;
    private bool isActive;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenu.SetActive(!mainMenu.activeInHierarchy);
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("SanAndreas");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        mainMenu.SetActive(!mainMenu.activeInHierarchy);
    }
}
