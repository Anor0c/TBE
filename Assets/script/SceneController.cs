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
    public void ToTest()
    {
        SceneManager.LoadScene(5);
    }
    public void TestKappa()
    {
        SceneManager.LoadScene(6);
    }
    public void TestFuta()
    {
        SceneManager.LoadScene(7);
    }
    public void TestPoulpe()
    {
        SceneManager.LoadScene(8);
    }
    public void TestCyclope()
    {
        SceneManager.LoadScene(9);
    }
    public void TestLanterne()
    {
        SceneManager.LoadScene(10);
    }
    public void TestTengu()
    {
        SceneManager.LoadScene(11);
    }
    public void ToSkinSelect()
    {
        SceneManager.LoadScene(12);
    }
    public void ToExit()
    {
        Application.Quit();
    }
}
