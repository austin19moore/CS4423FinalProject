using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterSoundHandler : MonoBehaviour
{
    GameObject text;
    void Start() {
        text = GameObject.Find("Canvas");
        text.SetActive(false);
    }

    public void Play()
    {
        GetComponent<AudioSource>().Play();
    }

    IEnumerator WaitText() {
        text.SetActive(true);
        yield return new WaitForSeconds(5);
        text.SetActive(false);
    }

    public void HandleText() {
        StartCoroutine(WaitText());
    }


}
