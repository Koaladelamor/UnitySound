using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlessTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !SoundManager.Instance.godBlessYou.isPlaying) {
            SoundManager.Instance.godBlessYou.Play();
        }
    }
}
