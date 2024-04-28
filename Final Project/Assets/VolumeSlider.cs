using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] AudioMixer mix;

    public void SetMaster(float level) {
        mix.SetFloat("Master", level);
    }
    
    public void SetSFX(float level) {
        mix.SetFloat("SFX", level);
    }

    public void SetMusic(float level) {
        mix.SetFloat("BackroundMusic", level);
    }
}
