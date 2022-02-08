using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiming : MonoBehaviour
{
    public Transform cannon;
    private Vector2 cannonAim;
    private Vector2 playerPos;
    private Player _player;
    public float lazerTrack;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_player == null)
        {
            return;
        }
        cannonAim = cannon.up;
        var playerDir = _player.transform.position  - cannon .position ;
        var aimLerp = Vector2.Lerp(cannonAim, playerDir, lazerTrack);
        cannon.up = aimLerp;

    }
}
