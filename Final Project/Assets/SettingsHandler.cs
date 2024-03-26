using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsHandler : MonoBehaviour
{
    public void ReturnButton() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("MainMenu");
    }
}
