using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform point;
    public float damage;
    public LineRenderer lineRenderer;
    public GameObject critical;
    void Start()
    {
        var gunCrit = GetComponent<player>();
    }
    void Update()
    {
        lineRenderer.SetPosition(0, point.position);
        lineRenderer.SetPosition(1, point.position + point.TransformDirection(Vector2.up) * 20f);
        RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up, 100f,LayerMask.GetMask("enemy","LazerPlayer") ,0);
        Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
        Laser laser = hitInfo.transform.GetComponent<Laser>();
        if (enemy != null)
        {
         enemy.TakeDamage(damage);
         Debug.Log("Hit");
        }
        if (laser !=null)
        {
         /*if (gunCrit.GunLevelUp>=5)
         { 
         Instantiate (critical, )
         }*/
        } 
    }  
}
