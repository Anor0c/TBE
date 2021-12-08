using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject PlayerSpawn, player1, player2;

    private void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(PlayerSpawn, transform);
        }
        else
        {
            var spawn = FindObjectOfType<player>().transform;
            var spawnPosition = spawn.position;
            var spawnParent = spawn.parent;
            Destroy(spawn.gameObject);
            Instantiate(player1, spawnPosition, quaternion.identity, spawnParent);
            Instantiate(player2, transform);
        }
    }
}

