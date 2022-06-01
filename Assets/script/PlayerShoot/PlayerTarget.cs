using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTarget : MonoBehaviour
{
    [SerializeField] float speed;
    public float damage;
    public float timeToDestroy;

    private Transform enemy;
    private Vector2 cible;
    private Enemy _enemy;
    Rigidbody2D rb;


    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("enemi").transform;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(enemy == null)
        {
                Destroy(gameObject);
        }
        cible = new Vector2(enemy.position.x, enemy.position.y);
        transform.position = Vector2.MoveTowards(transform.position, cible, speed * Time.deltaTime);
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