using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private string level1;

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(level1);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
