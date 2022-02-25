using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gunLevelUp : MonoBehaviour
{

    public int GunLevelRequirement;
    continuPlayer[] Cplayer;


    public void Start()
    {
        Cplayer = transform.GetComponentsInChildren<continuPlayer>();
        foreach (continuPlayer point in Cplayer)
        {
            //point.isActive = true;
            if (point.GunLevel != 0)
            {
                point.gameObject.SetActive(false);
            }
        }
    }

    public void GunLevelUp()
    {

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