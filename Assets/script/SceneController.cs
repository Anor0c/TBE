using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ToCharacterChoice()
    {
        SceneManager.LoadScene(1);
    }

    public void ToGameplay()
    {
        SceneManager.LoadScene(2);
    }
    public void ToGameOver()
    {
        SceneManager.LoadScene(3);
    }
    public void ToCredits()
    {
        SceneManager.LoadScene(4);
    }
    public void ToExit()
    {
        Application.Quit();
    }
}
