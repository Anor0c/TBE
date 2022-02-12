using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    private GameObject[] characterList;
    // Start is called before the first frame update
    void Start()
    {
        characterList = new GameObject[transform.childCount];
        for (int i= 0;i<transform .childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject character in characterList)
        {
            character.SetActive(false);
        }
        characterList[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
