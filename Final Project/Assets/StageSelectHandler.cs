using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectHandler : MonoBehaviour
{
    public void TutorialButton() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Tutorial");
    }

    public void Stage1Button() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Stage1");
    }

    public void ReturnButton() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("MainMenu");
    }
}
