using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    private MenuAudioHandler ah;

    void Start() {
        ah = GameObject.Find("MenuAudioHandler").GetComponent<MenuAudioHandler>();
    }


    public void StartButton() {
        ah.PlaySound();
        SceneManager.LoadScene("Tutorial");
    }

    public void StageSelectButton() {
        ah.PlaySound();
        SceneManager.LoadScene("StageSelect");
    }

    public void SettingsButton() {
        ah.PlaySound();
        SceneManager.LoadScene("Settings");
    }
    
    public void QuitButton() {
        ah.PlaySound();
        Application.Quit();
    }
}
