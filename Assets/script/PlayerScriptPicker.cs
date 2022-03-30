using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject playerSolo, player1, player2;
    public GameObject Cam1, Cam2;
    public Vector3 P2pos;

    private void Start()
    {


        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
        }
        else
        {
            var solo = FindObjectOfType<PlayerSolo>().transform;
            var soloHealth = solo.GetComponent<HealthBehaviour>();
            var soloHealthValue = soloHealth.health;
            var soloPosition = solo.position;
            var soloParent = solo.parent;
            Destroy(solo.gameObject);
            var playerOneInstance = Instantiate(player1, soloPosition, quaternion.identity, soloParent);
            playerOneInstance.GetComponent<HealthBehaviour>().health = soloHealthValue;
            Instantiate(player2, transform); ; //non rien
            Instantiate(Cam1);
            Instantiate(Cam2);

        }
    }
}