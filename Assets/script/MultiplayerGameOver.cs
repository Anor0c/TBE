using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiplayerGameOver : MonoBehaviour
{
    [SerializeField] UnityEvent onBothPlayersDied;
    public RectTransform P1Death, P2Death;

    public void MultiPlayerDeathEvents()
    {
        if (P1Death.gameObject.activeInHierarchy && P2Death.gameObject.activeInHierarchy)
            onBothPlayersDied?.Invoke();
        else
            return; 
    }
}
