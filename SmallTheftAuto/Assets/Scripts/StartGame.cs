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
            if (!isActive)
            {
                mainMenu.SetActive(true);
                isActive = true;
            }
            else
            {
                mainMenu.SetActive(false);
                isActive = false;
            }
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
        if(mainMenu.activeInHierarchy)
            mainMenu.SetActive(false);
        else
            mainMenu.SetActive(true);
    }
}
