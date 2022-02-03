using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTarget : MonoBehaviour
{
    [SerializeField] float speed;
    public float damage;
    private Transform enemy;
    private Vector2 cible;
    private Enemy _enemy;
    //Rigidbody2D rb;


    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("enemi").transform;

        //rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = player.transform.position * speed;

    }

    void Update()
    {
        cible = new Vector2(enemy.position.x, enemy.position.y);
        //transform.LookAt(player
        //rb.AddForce(cible * speed);
        transform.position = Vector2.MoveTowards(transform.position, cible, speed * Time.deltaTime);
        //transform.Translate(Vector2.up * speed * Time.deltaTime); les bullets evitent le player
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        _enemy = hitInfo.GetComponent<Enemy>();
        if (_enemy != null)
        {
            _enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}