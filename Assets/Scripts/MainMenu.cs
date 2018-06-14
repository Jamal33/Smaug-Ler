using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // Start the game
    public void Play()
    {
        SceneManager.LoadScene("background");
    }

    // Exit the game (only works on builded version)
    public void Quit()
    {
        Application.Quit();
    }

}
