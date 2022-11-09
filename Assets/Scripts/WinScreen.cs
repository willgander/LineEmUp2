using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private string nextLevel;
    [SerializeField] private string mainMenu;

    public void OnNextLevelButtonClick()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void MainMenuButtonClick()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
