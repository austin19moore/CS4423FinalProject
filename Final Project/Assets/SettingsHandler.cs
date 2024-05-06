using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsHandler : MonoBehaviour
{
    private MenuAudioHandler ah;

    void Start() {
        ah = GameObject.Find("MenuAudioHandler").GetComponent<MenuAudioHandler>();
    }
    public void ReturnButton() {
        ah.PlaySound();
        SceneManager.LoadScene("MainMenu");
    }
}
