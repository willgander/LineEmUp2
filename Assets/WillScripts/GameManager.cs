using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    public GameObject tile5;
    public GameObject winPanel;
    public AudioSource winSound;

    [SerializeField] private string nextLevel;
    [SerializeField] private string mainMenu;

    private void FixedUpdate()
    {
        
        if (tile1.transform.position.x < tile2.transform.position.x)
        {

            if (tile2.transform.position.x < tile3.transform.position.x)
            {
                if (tile3.transform.position.x < tile4.transform.position.x)
                {
                    if (tile4.transform.position.x < tile5.transform.position.x)
                    {

                        StartCoroutine(winDelay());



                    }
                }
            }
        }
    }


    void OnMouseDown()
    {
        
    }


    IEnumerator winDelay()
    {
        yield return new WaitForSeconds(2);
        winSound.Play(0);
        SceneManager.LoadScene(nextLevel);
        //win();
    }



    private void win()
    {
        winSound.Play(0);
        winPanel.gameObject.SetActive(true);
        
    }

    public void OnNextLevelButtonClick()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void MainMenuButtonClick()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
