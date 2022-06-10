using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceSound : MonoBehaviour
{
    public AudioClip creepy1;
    public AudioClip creepy2;

    public AudioSource ambienceSource;

    // Update is called once per frame
    void Update()
    {
        if (!ambienceSource.isPlaying) {
            if (ambienceSource.clip == creepy1) 
            {
                ambienceSource.clip = creepy2;
                ambienceSource.Play();
            }
            else if (ambienceSource.clip == creepy2)
            {
                ambienceSource.clip = creepy1;
                ambienceSource.Play();
            }
        }
    }
}
