using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiming : MonoBehaviour
{
    public Transform cannon;
    private Vector2 cannonAim;
    private Vector2 playerPos;
    private HealthBehaviour _player;
    public float lazerTrack;

    // Update is called once per frame
    void Update()
    {
        _player = GameObject.FindObjectOfType<HealthBehaviour>();
        if (_player == null)
            return;
        cannonAim = cannon.up;
        var playerDir = _player.transform.position - cannon.position;
        //Plus laserTrack est elevé, plus le lazer est précis. Il vise parfaitement a 1
        var aimLerp = Vector2.Lerp(cannonAim, playerDir, lazerTrack);
        cannon.up = aimLerp;
    }
}
