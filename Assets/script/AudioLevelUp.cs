using UnityEngine;
using UnityEngine.Audio;

public class AudioLevelUp : MonoBehaviour
{
    public float transitionTime;

    public gunLevelUp gunLevel;
    public AudioMixerSnapshot[] snapShots;

    private void Update()
    {
        if (gunLevel.GunLevelRequirement >= 4)
            snapShots[2].TransitionTo(transitionTime);


        if (2 <= gunLevel.GunLevelRequirement && gunLevel.GunLevelRequirement < 4)
            snapShots[1].TransitionTo(transitionTime);
        


        if (gunLevel.GunLevelRequirement < 2)
            return;
    }
}
