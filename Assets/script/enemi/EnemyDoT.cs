using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoT : MonoBehaviour
{
    public float damage = 1;
    public float ProjLifeTime;
    public float ProjEnlargeX;
    public float ProjEnlargeY;

    private void Update()
    {
        if (ProjLifeTime > 0f)
        {
            ProjLifeTime -= Time.deltaTime;
            //bullet.transform.localScale = new Vector3(bullet.transform.localScale.x + ProjEnlargeX, bullet.transform.localScale.y + ProjEnlargeY, bullet.transform.localScale.z);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D hitInfo)
    {
        HealthBehaviour enemi = hitInfo.GetComponent<HealthBehaviour>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
    }
}