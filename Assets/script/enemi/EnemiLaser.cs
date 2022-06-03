using System.Collections;
using UnityEngine;

public class EnemiLaser : MonoBehaviour
{
    public Transform point;
    public LineRenderer lineRenderer;
    public BoxCollider2D lazerHit;

    public float damage;
    public float pauseTime;
    public float lazerTime;

    private bool isLazer;
    private void Start()
    {
        isLazer = true;
        StartCoroutine(Lazer());
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        HealthBehaviour enemi = collision.GetComponent<HealthBehaviour>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }

    }
    private IEnumerator Lazer()
    {
        var routineTime = isLazer ? lazerTime : pauseTime;
        //verifie is issLazer est true, si il est true, routineTime=lazerTime, sinon, routineTime=pauseTime
        yield return new WaitForSeconds(routineTime);
        if (isLazer)
            LazerAct();
        else
            LazerDeac();

    }
    private void LazerAct()
    {
        lineRenderer.enabled = true;
        lazerHit.enabled = true;
        isLazer = true;
    }
    private void LazerDeac()
    {
        lineRenderer.enabled = false;
        lazerHit.enabled = false;
        isLazer = false;
    }
}