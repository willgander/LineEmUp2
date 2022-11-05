using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    public GameObject tile5;
    public GameObject winPanel;

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
<<<<<<< Updated upstream
                        StartCoroutine(winDelay());
=======
                        win();
>>>>>>> Stashed changes
                    }
                }
            }
        }
    }

<<<<<<< Updated upstream
    IEnumerator winDelay()
    {
        yield return new WaitForSeconds(2);
        win();
    }


=======
>>>>>>> Stashed changes
    private void win()
    {
        winPanel.gameObject.SetActive(true);
    }

}
