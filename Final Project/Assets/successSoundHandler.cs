using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class successSoundHandler : MonoBehaviour
{
    public void Play() {
        GetComponent<AudioSource>().Play();
    }
}
