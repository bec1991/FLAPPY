using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndOfGame : MonoBehaviour
{
    

   public void QuitGame()
    {
        Debug.Log ("quit");
        Application.Quit();
    }

    public void RestartGame()
    {
    	Debug.Log("Restart TIME");
        SceneManager.LoadScene(2);
    }
}
