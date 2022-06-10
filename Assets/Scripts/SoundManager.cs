using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundManager : MonoBehaviour
{

    static SoundManager mInstance;

    static public SoundManager Instance
    {
        get { return mInstance; }
        private set { }
    }

    public AudioSource effectsSounds;
    public AudioSource BackgroungMusic;
    public AudioSource slenderFootstepAudioSource;
    public AudioSource godBlessYou;

    public AudioClip rightFootstep;
    public AudioClip leftFootstep;
    public AudioClip grassFootsteps;
    public AudioClip metalGate;
    public AudioClip crowSound;
    public AudioClip fireSound;
    public AudioClip blessingMusic;

    public AudioClip creepyAmbience;

    public enum AudioEffects { NONE, RIGHT_FOOTSTEP, LEFT_FOOTSTEP, GRASS_FOOTSTEP };

    public enum InstantAudios { NONE, FOOTSTEP_RIGHT, FOOTSTEP_LEFT, FOOTSTEP_GRASS, GATE, GATE2, CROW, FIRE, BLESSING };

    private InstantAudios instantAudios;

    private void Awake()
    {
        //Singleton
        if (mInstance == null)
        {
            mInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

    }

    //*****************************************
    public void PlayOnce(AudioEffects effect)
    {

        effectsSounds.Stop();

        switch (effect)
        {
            case AudioEffects.NONE:
                break;
            case AudioEffects.RIGHT_FOOTSTEP:
                effectsSounds.clip = rightFootstep;
                break;
            case AudioEffects.LEFT_FOOTSTEP:
                effectsSounds.clip = leftFootstep;
                break;
            case AudioEffects.GRASS_FOOTSTEP:
                effectsSounds.clip = grassFootsteps;
                break;
            default:
                break;
        }

        effectsSounds.Play();

    }

    //public InstantAudios GetInstantAudio(InstantAudi)
    public void PlayInstant(InstantAudios instantAudio)
    {
        instantAudios = instantAudio;
        switch (instantAudios)
        {
            case InstantAudios.NONE:
                break;
            case InstantAudios.FOOTSTEP_RIGHT:
                effectsSounds.PlayOneShot(rightFootstep);
                break;
            case InstantAudios.FOOTSTEP_LEFT:
                effectsSounds.PlayOneShot(leftFootstep);
                break;
            case InstantAudios.FOOTSTEP_GRASS:
                effectsSounds.PlayOneShot(grassFootsteps);
                break;
            case InstantAudios.GATE:
                effectsSounds.PlayOneShot(metalGate);
                break;
            case InstantAudios.CROW:
                effectsSounds.PlayOneShot(crowSound);
                break;
            case InstantAudios.FIRE:
                effectsSounds.PlayOneShot(fireSound);
                break;
            case InstantAudios.BLESSING:
                effectsSounds.PlayOneShot(blessingMusic);
                break;
            default:
                break;
        }
    }

    public void PlayLeftFootstep() {
        slenderFootstepAudioSource.Stop();
        slenderFootstepAudioSource.clip = leftFootstep;
        slenderFootstepAudioSource.Play();
    }
    public void PlayRightFootstep()
    {
        slenderFootstepAudioSource.Stop();
        slenderFootstepAudioSource.clip = rightFootstep;
        slenderFootstepAudioSource.Play();
    }
}