using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");

    }

    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");

    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log ("quit");
        Application.Quit();
    }
}
