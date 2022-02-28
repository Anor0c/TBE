using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gunLevelUp : MonoBehaviour
{
    public int modeIndex;
    public int GunLevelRequirement;
    continuPlayer[] Cplayer;
    private PlayerMode playerMode;

    public void Start()
    {
        playerMode = GetComponent<PlayerMode>();
        
        Cplayer = transform.GetComponentsInChildren<continuPlayer>();
        foreach (continuPlayer point in Cplayer)
        {
            //point.isActive = true;
            if (point.GunLevel != 0)
            {
                point.gameObject.SetActive(false);
            }
            /*if (modeIndex != playerMode.modeIndex)
            {
                point.gameObject.SetActive(false);
            }*/
        }
    }

    public void GunLevelUp()
    {
        /*if (modeIndex != playerMode.modeIndex) 
        {
            return;
        }*/
        GunLevelRequirement++;
        foreach (continuPlayer point in Cplayer)
        {
            if (GunLevelRequirement >= point.GunLevel)
            {
                Debug.Log(Cplayer[3]);
                Debug.Log("LeveledUp");
                point.gameObject.SetActive(true);
            }
        }
    }
}