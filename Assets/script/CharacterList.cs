using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
    GameObject[] characterList;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        characterList = new GameObject[transform.childCount];
        for (int i=0;i<transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject child in characterList)
        {
            child.SetActive(false);
        }
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
    }

    public void ButtonLeft()
    {
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }
        characterList[index].SetActive(true);
    }
    public void ButtonRight()
    {
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length) 
        {
            index = 0;
        }
        characterList[index].SetActive(true);
    }
}
