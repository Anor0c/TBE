using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2 : MonoBehaviour
{
    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player2");
    }
}
