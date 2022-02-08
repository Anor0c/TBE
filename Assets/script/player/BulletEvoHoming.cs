using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEvoHoming : MonoBehaviour
{
    private Enemy _enemy;
    private Transform enemy;
    private Rigidbody2D rb;
    public float damage;
    public float speedSlow;
    public float speedFast;
    private Vector2 cible;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("enemi").transform;

        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            return;
        }
        // créer de la logique pour faire avancer la bullet a speedSlow pendant waitTime puis invoke(?) TargetEnemy
        rb.velocity = transform.up * speedSlow;
        Invoke("TargetEnemy", waitTime);
    }
    private void TargetEnemy()
    {
        rb.velocity = Vector2.zero;
        cible = new Vector2(enemy.position.x, enemy.position.y);
        transform.position = Vector2.MoveTowards(transform.position, cible, speedFast * Time.deltaTime);
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
