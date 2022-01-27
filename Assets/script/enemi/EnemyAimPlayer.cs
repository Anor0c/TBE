using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAimPlayer : MonoBehaviour
{
    private player _player;
    public Transform gun;
    private Vector2 playerPos;
    private float percentage;
    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //gun = (Vector2.Lerp(gun.up,_player.transform.position , percentage));
    }
}
