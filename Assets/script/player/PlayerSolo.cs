using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSolo : MonoBehaviour
{
    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player");
    }
}