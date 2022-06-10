using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterList : MonoBehaviour
{
    GameObject[] characterList;
    public int index;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
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
