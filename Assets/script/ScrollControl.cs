using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollControl : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    GameObject[] enemy;
    private int EnemyCount;
    public float SlowMultiplier;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -speed;
        
    }
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("enemi");
        EnemyCount = enemy.Length;
        if (EnemyCount <= 0)
        {
            rb.velocity = transform.up *(-speed-10);
        } 
        else
        {
            rb.velocity = transform.up * (-speed+(SlowMultiplier*EnemyCount));
        }
    }
}
