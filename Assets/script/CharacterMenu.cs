using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMenu : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;
    private bool isRight;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnMenuMoveRight(InputAction .CallbackContext obj)
    {
        OnMenuMove(isRight = true);
    }
    void OnMenuMove(bool isRight)
    {
        if (isRight)
        {
            characterList[index].SetActive(false);
            index--;
            if (index < 0)
            {
                index = characterList.Length - 1;
            }
        }
        characterList[index].SetActive(false);
        index++;
        if(index ==characterList .Length)
        {
            index = 0;
        }
    }
}