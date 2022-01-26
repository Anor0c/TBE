using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCloseEnemi : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    GameObject bullet;
    public float timeToDestroy;
    public float damage = 40;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        StartCoroutine(DestroyCorutine());
    }
    IEnumerator DestroyCorutine()
    {
        rb.velocity = transform.up *speed;
        new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
        yield return null;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        player enemi = hitInfo.GetComponent<player>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}