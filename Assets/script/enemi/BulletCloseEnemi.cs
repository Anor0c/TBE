using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCloseEnemi : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public float timeToDestroy;
    public float damage = 40;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up *speed;
        Invoke("DestroyBullet", timeToDestroy);
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        HealthBehaviour enemi = hitInfo.GetComponent<HealthBehaviour>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}