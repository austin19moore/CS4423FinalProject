using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public void StartButton() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Tutorial");
    }

    public void StageSelectButton() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("StageSelect");
    }

    public void SettingsButton() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Settings");
    }
    
    public void QuitButton() {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
