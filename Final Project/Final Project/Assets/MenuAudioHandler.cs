using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuAudioHandler : MonoBehaviour
{
    public static MenuAudioHandler singleton = null;
    private AudioSource sound;

    void Start() {
        sound = GetComponent<AudioSource>();
    }

    void Awake() {
        if (singleton != null) {
            Destroy(this.gameObject);
            return;
        } else {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }

    public void PlaySound() {
        sound.Play();
    }
}
