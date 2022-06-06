using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinMode : MonoBehaviour
{
    public SkinChoice skinIndex;
    public Sprite[] skin;

    [SerializeField] private int modeIndex;
    private SpriteRenderer sr;
    private SkinMode[] P2Check;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        skinIndex = FindObjectOfType<SkinChoice>();
        P2Check = FindObjectsOfType<SkinMode>();

        if (skinIndex == null)
            modeIndex = 0;

        else
            modeIndex = skinIndex.index;

        /*if (P2Check.Length < 2)
            return;
        modeIndex = modeIndex - 1;

        if (modeIndex < 0)
            modeIndex = 1;*/

        ModeSwitch(modeIndex);
    }

    public void ModeSwitch(int index)
    {
       sr.sprite = skin[index];       
    }
}
