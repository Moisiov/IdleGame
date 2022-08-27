using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject settingsMenu;



    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void openOptions()
    {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void toMainMenu()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}