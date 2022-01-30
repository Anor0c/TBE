using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiLaser : MonoBehaviour
{
    public Transform point;
    public float damage;
    public LineRenderer lineRenderer;

    public float pauseTime;
    public float pauseLimite;
    private float currentLazerTime;
    private float varCurrentLazer;
    void Start()
    {
    }
    void Update()
    {
        var waitTime = currentLazerTime + pauseLimite;
        if(waitTime <Time .time)
        {
            currentLazerTime = Time.time;
            varCurrentLazer += currentLazerTime;

            lineRenderer.SetPosition(0, point.position);
            lineRenderer.SetPosition(1, point.position + point.TransformDirection(Vector2.up) * 20f);
            RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up, 100f);
            if (hitInfo.transform == null) 
            {
                return;
            }
            else
            {
                player enemy = hitInfo.transform.GetComponent<player>();

                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
            }
        }
        if(currentLazerTime == pauseLimite) 
        {
            varCurrentLazer = 0f;
            // il faudrait de  la logique pour mettre des pauses, utiliser Invoke?????
        }
    }
}
