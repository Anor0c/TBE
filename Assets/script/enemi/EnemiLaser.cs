using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiLaser : MonoBehaviour
{
    public Transform point;
    public float damage;
    public LineRenderer lineRenderer;

    public float pauseTime;
    public float lazerTime;
    private float currentLazerTime;
    private float waitTime;
    private bool isLazer=true; 
    void Start()
    {
        currentLazerTime = lazerTime;

    }
    void Update()
    {

        currentLazerTime -= Time.deltaTime;
        waitTime = currentLazerTime + pauseTime ;
        if (currentLazerTime <= 0f) 
        {
            isLazer = false;
            // il faudrait de  la logique pour mettre des pauses, utiliser booollean 
        }
        if(waitTime <= 0f)
        {
            currentLazerTime = lazerTime ;
            isLazer = true;
        }


        if(isLazer == true)
        {
            Lazer();
        }
        else
        {
            lineRenderer.SetPosition(0, point.position);
            lineRenderer.SetPosition(1, point.position);
        }
    }
    private void Lazer()
    {
        {
            lineRenderer.SetPosition(0, point.position);
            lineRenderer.SetPosition(1, point.position + point.TransformDirection(Vector2.up) * 20f);
            RaycastHit2D hitInfo = Physics2D.Raycast(point.position, point.up, 100f, LayerMask.GetMask("Default"), 0);
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
                    Debug.Log("Player hit!!");
                }
            }


        }
    }
}
