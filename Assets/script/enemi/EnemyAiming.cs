using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiming : MonoBehaviour
{
    public Transform cannon;
    private Vector2 cannonAim;
    private Vector2 playerPos;
    private player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindObjectOfType<player>();   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_player == null)
        {
            return;
        }
        cannonAim = cannon.up;
        playerPos = _player.transform.position;
        var cannonAimCurrent = cannonAim - playerPos;

        var percentage = (playerPos - cannonAimCurrent).magnitude; 
        var aimLerp = Vector2.Lerp(cannonAim, playerPos, percentage);
        cannon.up = aimLerp;

    }
}
