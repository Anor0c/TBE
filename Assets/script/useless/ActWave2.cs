using UnityEngine;
using UnityEngine.InputSystem;

public class ActWave2 : MonoBehaviour
{
    public Wave waveP1;
    private int waveCountP2;

    void Update()
    {
        if (PlayerInputManager.instance.playerCount <= 1) 
        {
            return;
        }
        this.gameObject.SetActive(true);
        waveCountP2 = waveP1.waveCount;
    }
}
