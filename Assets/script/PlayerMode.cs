using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMode : MonoBehaviour
{
    public CharacterList CharaIndex;
    [SerializeField]  private int modeIndex;
    gunLevelUp[] playerMode;


    void Awake()
    {
        //Logique pour avoir le choix de perso qui influe playerMode. 
        CharaIndex = FindObjectOfType<CharacterList>();
        if (CharaIndex == null)
            modeIndex = 0;

        else
            modeIndex = CharaIndex.index;

        ModeSwitch(modeIndex);
    }
    public void ModeSwitch(int index)
    {
        playerMode = transform.GetComponentsInChildren<gunLevelUp>();
        foreach (gunLevelUp mode in playerMode)
        {

            if (index != mode.modeIndex)
            {
                Debug.Log("MODE");
                Destroy(mode.gameObject);
            }
        }
    }
}