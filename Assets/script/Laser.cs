using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform point;
    public float damage;
    void Start()
    {
          
    }
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up);
        if (hitInfo)
        {
            Enemy enemy = GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
           
        }
    }
}
