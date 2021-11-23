using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{ 
    public GameObject en;
    public Transform point;
    public void spawn()
    {
        Instantiate(en, point.position, Quaternion.identity);
    }
}
