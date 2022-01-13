using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafaleEnemy : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public int damage = 40;
    public player player;
    Vector2 moveDirection;
    public float decalX, decalY;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<player>();
        moveDirection = (player.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x=decalX , moveDirection.y+decalY);
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
