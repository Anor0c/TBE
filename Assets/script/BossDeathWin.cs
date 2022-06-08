using UnityEngine;
using UnityEngine.Events;

public class BossDeathWin : MonoBehaviour
{
    public UnityEvent onBossDeath;
    
    public void BossDied()
    {
        onBossDeath?.Invoke();
    }
}
