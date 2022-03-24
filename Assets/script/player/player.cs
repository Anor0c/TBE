using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player1");
    }
}
