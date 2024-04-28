using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioHandler : MonoBehaviour
{
    private static MenuAudioHandler singleton = null;
    private AudioSource sound;

    void Start() {
        sound = GetComponent<AudioSource>();
    }

    public static MenuAudioHandler Instance {
        get {
            return singleton;
        }
    }

    void Awake() {
        if (singleton != this && singleton != null) {
            Destroy(this.gameObject);
            return;
        } else {
            singleton = this;
        }

        DontDestroyOnLoad(this.gameObject);

    }

    public void PlaySound() {
        sound.Play();
    }
}
