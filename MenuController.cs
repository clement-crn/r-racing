using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class MenuController : MonoBehaviour
{
    public string levelToLoad;

    public GameObject settingsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void StartGameLevel2()
    {
        SceneManager.LoadScene(2);
    }
     public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
    public void StartTestLand()
    {
        SceneManager.LoadScene(2);
    }
    public void SettingsButton()
    {
        settingsWindow.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    

    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame ()
    {
        Time.timeScale = 0;
        
    }
    public void ResumeGame ()
    {
        Time.timeScale = 1;
       
    
    }
}
