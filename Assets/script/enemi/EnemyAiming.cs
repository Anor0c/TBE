using UnityEngine.InputSystem;
using UnityEngine;

public class EnemyAiming : MonoBehaviour
{
    public Transform cannon;
    public float lazerTrack;
    public PlayerMode[] playerList;

    private Vector2 cannonAim;
    private PlayerMode _player;


    // Update is called once per frame
    void Update()
    {
        playerList = FindObjectsOfType<PlayerMode>();

        if (PlayerInputManager.instance.playerCount == 0) 
            return;
        else
        {
            if (PlayerInputManager.instance.playerCount == 1) 
                _player = playerList[0];

            if (PlayerInputManager.instance.playerCount >= 2) 
            {
                if (this.transform.position.x > 800)
                    _player = playerList[0];
                else
                    _player = playerList[1];
            }

            if (_player == null)
                return;

            cannonAim = cannon.up;
            var playerDir = _player.transform.position - cannon.position;

            //Plus laserTrack est elevé, plus le lazer est précis. Il vise parfaitement a 1
            var aimLerp = Vector2.Lerp(cannonAim, playerDir, lazerTrack);
            cannon.up = aimLerp;
        }
    }
}
