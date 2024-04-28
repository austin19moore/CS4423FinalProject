using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectHandler : MonoBehaviour
{
    private MenuAudioHandler ah;

    void Start() {
        ah = GameObject.Find("MenuAudioHandler").GetComponent<MenuAudioHandler>();
    }
    public void TutorialButton() {
        ah.PlaySound();
        SceneManager.LoadScene("Tutorial");
    }

    public void Stage1Button() {
        ah.PlaySound();
        SceneManager.LoadScene("Stage1");
    }

    public void Stage2Button() {
        ah.PlaySound();
        SceneManager.LoadScene("Stage2");
    }

    public void ChamberButton() {
        ah.PlaySound();
        SceneManager.LoadScene("Chamber");
    }

    public void FinalStageButton() {
        ah.PlaySound();
        SceneManager.LoadScene("FinalStage");
    }

    public void ReturnButton() {
        ah.PlaySound();
        SceneManager.LoadScene("MainMenu");
    }
}
