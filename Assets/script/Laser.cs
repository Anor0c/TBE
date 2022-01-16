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
        lineRenderer.SetPosition(0, point.position);
        lineRenderer.SetPosition(1, point.position + point.TransformDirection(Vector2.up) * 20f);
        RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up, 100f,LayerMask.GetMask("enemy","LazerPlayer") ,0);
        Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
        
        {
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Debug.Log("Hit");
            }
           /* if ()
            {
           Logique pour créer un point critique accessible a la jonction des 2 lasers au niveau 6 de GunLevelUp
            } */
        }
    }  
}
