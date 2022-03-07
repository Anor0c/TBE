using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMode : MonoBehaviour
{
    public int modeIndex;
    gunLevelUp[] playerMode;

    void Awake()
    {
        //Logique pour avoir le choix de perso qui influe playerMode. 
        playerMode = transform.GetComponentsInChildren<gunLevelUp>();
        foreach (gunLevelUp mode in playerMode)
        {

            if (modeIndex != mode.modeIndex) 
            {
                Debug.Log(this);
                Destroy(mode.gameObject);
            }
        }
    }
}