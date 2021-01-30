﻿
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ChooseLvl()
    {
        SceneManager.LoadScene("LevelPick");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
