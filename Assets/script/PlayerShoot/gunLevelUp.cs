using UnityEngine;
using System.Collections.Generic;

public class gunLevelUp : MonoBehaviour
{
    public int modeIndex;
    public int GunLevelRequirement;
    continuPlayer[] Cplayer;
    private PlayerMode playerMode;
    public List<GameObject> LootList; //added

    public void Start()
    {
        playerMode = GetComponentInParent<PlayerMode>();
        
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

    void OnTriggerEnter2D(Collider2D hitInfo) //added
    {
        if (hitInfo.gameObject != null && LootList.Contains(hitInfo.gameObject))
        {
            GunLevelUp();
        }
    }
    public void GunLevelUp()
    {
        /*if (modeIndex != playerMode.modeIndex) 
        {
            return;
        }*/
        
        Debug.Log("gun level +1");
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