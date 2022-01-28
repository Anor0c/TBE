using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiLaser : MonoBehaviour
{
    public Transform point;
    public float damage;
    public float EnemyLaserPause;
    public LineRenderer lineRenderer;
    void Start()
    {
        var gunCrit = GetComponent<Enemy>();
        StartCoroutine(LazerCoroutine());
    }
    void Update()
    {

    }
    IEnumerator LazerCoroutine()
    {
        lineRenderer.SetPosition(0, point.position);
        lineRenderer.SetPosition(1, point.position + point.TransformDirection(Vector2.up) * 20f);
        RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up, 100f);
        player enemy = hitInfo.transform.GetComponent<player>();
        if (enemy == null)
        {
            Debug.Log("No Ennemi");
        }
        else if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Debug.Log("Hit");
        }
        yield return new WaitForSeconds(EnemyLaserPause);
    }
}
