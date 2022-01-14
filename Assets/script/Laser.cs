using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform point;
    public float damage;
    public LineRenderer lineRenderer;
    void Start()
    {
          
    }
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up);
        Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
        {
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            lineRenderer.SetPosition(0, point.position);
            lineRenderer.SetPosition(1, point.position + point.TransformDirection(Vector2.up) * 20f);
        }
    }   
}
