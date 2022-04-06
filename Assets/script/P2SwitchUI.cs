using UnityEngine;
using UnityEngine.UI;

public class P2SwitchUI : MonoBehaviour
{
    [HideInInspector] public RectTransform healthBar;

    private void Start()
    {
        healthBar = GetComponent<RectTransform>();
    }

   /* public void Player2Switch()
    {
        healthBar = new RectTransform (anc)
    }*/
}
