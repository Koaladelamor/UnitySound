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

    public AudioClip selectSound;
    public AudioClip pressedSound;
    public AudioClip bagCloseSound;
    public AudioClip bagOpenSound;
    public AudioClip arrowHitFlesh;
    public AudioClip beOnYourGuard;
    public AudioClip birdSound;
    public AudioClip chestOpeningSound;
    public AudioClip coinDroppedSound;
    public AudioClip dramaticBirdsSound;
    public AudioClip owlSound;
    public AudioClip wolfHowlSound;
    public AudioClip swordHitFleshSound;
    public AudioClip swordHitObjectSound;
    public AudioClip swordHitMetalSound;
    public AudioClip GrodnarDeathSound;
    public AudioClip SigfridDeathSound;
    public AudioClip LanstarDeathSound;

    public AudioClip BellSound;
    public AudioClip enemyHurt;
    public AudioClip playerHurt;
    public AudioClip lifeSound;

    public enum AudioEffects { NONE, SELECT, PRESSED, LIFESOUND };

    public enum InstantAudios { NONE, ENEMYHURT, PLAYERHURT, BAGCLOSE, BAGOPEN, ARROWFLESH, ONGUARD, BIRD, CHESTOPEN, COIN, DRAMATICBIRD, OWL, WOLFHOWL, SWORDFLESH, SWORDOBJECT, SWORDMETAL, GRODNARDEATH, SIGFRIDDEATH, LANSTARDEATH, BELLSOUND };

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
            case AudioEffects.SELECT:
                effectsSounds.clip = selectSound;
                break;
            case AudioEffects.PRESSED:
                effectsSounds.clip = pressedSound;
                break;
            case AudioEffects.LIFESOUND:
                effectsSounds.clip = bagCloseSound;
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
            case InstantAudios.ENEMYHURT:
                effectsSounds.PlayOneShot(enemyHurt);
                break;
            case InstantAudios.PLAYERHURT:
                effectsSounds.PlayOneShot(playerHurt);
                break;
            case InstantAudios.BAGCLOSE:
                effectsSounds.PlayOneShot(bagCloseSound);
                break;
            case InstantAudios.BAGOPEN:
                effectsSounds.PlayOneShot(bagOpenSound);
                break;
            case InstantAudios.ARROWFLESH:
                effectsSounds.PlayOneShot(arrowHitFlesh);
                break;
            case InstantAudios.ONGUARD:
                effectsSounds.PlayOneShot(beOnYourGuard);
                break;
            case InstantAudios.BIRD:
                effectsSounds.PlayOneShot(birdSound);
                break;
            case InstantAudios.CHESTOPEN:
                effectsSounds.PlayOneShot(chestOpeningSound);
                break;
            case InstantAudios.COIN:
                effectsSounds.PlayOneShot(coinDroppedSound);
                break;
            case InstantAudios.DRAMATICBIRD:
                effectsSounds.PlayOneShot(dramaticBirdsSound);
                break;
            case InstantAudios.OWL:
                effectsSounds.PlayOneShot(owlSound);
                break;
            case InstantAudios.WOLFHOWL:
                effectsSounds.PlayOneShot(wolfHowlSound);
                break;
            case InstantAudios.SWORDFLESH:
                effectsSounds.PlayOneShot(swordHitFleshSound);
                break;
            case InstantAudios.SWORDOBJECT:
                effectsSounds.PlayOneShot(swordHitObjectSound);
                break;
            case InstantAudios.SWORDMETAL:
                effectsSounds.PlayOneShot(swordHitMetalSound);
                break;
            case InstantAudios.GRODNARDEATH:
                effectsSounds.PlayOneShot(GrodnarDeathSound);
                break;
            case InstantAudios.SIGFRIDDEATH:
                effectsSounds.PlayOneShot(SigfridDeathSound);
                break;
            case InstantAudios.LANSTARDEATH:
                effectsSounds.PlayOneShot(LanstarDeathSound);
                break;
            case InstantAudios.BELLSOUND:
                effectsSounds.PlayOneShot(BellSound);
                break;
            default:
                break;
        }

    }
}