using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject playUI;


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene ("Game2");
        Time.timeScale = 1f;
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }

    public void Resume(){
        menuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void Play(){
        playUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause (){
        menuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
