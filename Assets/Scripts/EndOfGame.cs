using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndOfGame : MonoBehaviour
{



    public void Start()
    {
       
        
    }



    public void QuitGame()
    {
        Debug.Log ("quit");
        Application.Quit();
    }

    public void RestartGame()
    {
    	Debug.Log("Restart TIME");
        SceneManager.LoadScene("Main Menu");

        Score.score = 0f;


    }

}
