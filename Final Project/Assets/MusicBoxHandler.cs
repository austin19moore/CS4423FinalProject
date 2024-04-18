using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxHandler : MonoBehaviour
{
    AudioSource theme;
    // Start is called before the first frame update
    void Start()
    {
        theme = GetComponent<AudioSource>();
    }

    public void StopMusic() {
        theme.Pause();
    }
}
