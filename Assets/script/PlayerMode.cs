using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMode : MonoBehaviour
{
    public int modeIndex;
    gunLevelUp[] playerMode;
    // Start is called before the first frame update
    void Start()
    {

        foreach (gunLevelUp mode in playerMode)
        {
            if (modeIndex != mode.modeIndex) 
            {
                Destroy(mode.gameObject);
            }
        }
    }
}