using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void End()
    {
        SceneManager.LoadScene("End");
    }

    public void Vuforia()
    {
        SceneManager.LoadScene("ARScene");
    }
}
