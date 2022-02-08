using UnityEngine.InputSystem;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject stop;
    public void OnPause(InputAction.CallbackContext context)
    {
        Time.timeScale = 0f;
        stop.SetActive(true);
    }
    public void OnPlay(InputAction.CallbackContext context)
    {
        Time.timeScale = 1f;
        stop.SetActive(false);
    }
}
