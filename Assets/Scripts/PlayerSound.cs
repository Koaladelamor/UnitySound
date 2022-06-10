using UnityEngine;

public class PlayerSound : MonoBehaviour
{

    

    public void PlayLeftFoot()
    {
        SoundManager.Instance.PlayLeftFootstep();
    }

    public void PlayRightFoot()
    {
        SoundManager.Instance.PlayRightFootstep();
    }
}
