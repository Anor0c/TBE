using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoT : MonoBehaviour
{
    GameObject bullet;
    public float damage = 1;
    private player player;
    public float ProjLifeTime;
    public float ProjEnlargeX;
    public float ProjEnlargeY;
void Start()
{
    player = GameObject.FindObjectOfType<player>();
}
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
        player enemi = hitInfo.GetComponent<player>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
    }
}