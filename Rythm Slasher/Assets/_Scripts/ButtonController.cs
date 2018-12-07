using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {




    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Game")
        {
            SceneManager.LoadScene("Game");
        }
        if (other.gameObject.tag =="Instructions")
        {
            SceneManager.LoadScene("Instructions");
        }
        if (other.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene("Exit");
            Application.Quit();
        }
        if (other.gameObject.tag == "MenuScene" )
        {
            SceneManager.LoadScene("Start");
        }
        if (other.gameObject.tag == "End")
        {
            SceneManager.LoadScene("End");
        }
    }
}
