using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageSoundHandler : MonoBehaviour
{
    private AudioSource damageaudio;
    // Start is called before the first frame update
    void Start()
    {
        damageaudio = GetComponent<AudioSource>();
    }

    public void PlaySound() {
        damageaudio.Play();
    }
}
