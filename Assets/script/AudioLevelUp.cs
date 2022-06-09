using UnityEngine;
using UnityEngine.Audio;

public class AudioLevelUp : MonoBehaviour
{
    public float transitionTime;

    public gunLevelUp gunLevel;
    public AudioMixerSnapshot[] snapShots;

    private void Update()
    {
        if (gunLevel.GunLevelRequirement >= 5)
            snapShots[2].TransitionTo(transitionTime);


        if (3 <= gunLevel.GunLevelRequirement && gunLevel.GunLevelRequirement < 5)
            snapShots[1].TransitionTo(transitionTime);
        


        if (gunLevel.GunLevelRequirement < 3)
            return;
    }
}
