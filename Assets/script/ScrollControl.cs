using UnityEngine;
using System.Collections.Generic;

public class ScrollControl : MonoBehaviour
{
    public Wave _wave;
    [HideInInspector] public Vector2 scrollVelocity;
    [HideInInspector] public Rigidbody2D rb;

    [SerializeField] float speed;
    [SerializeField] int enemyCount;
    public float SlowMultiplier;
    public float fastMultiplier;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -speed;
        
    }
    void Update()
    {
        enemyCount = _wave.enemyCount;
        if (enemyCount <= 0)
                    rb.velocity = transform.up *(-speed-fastMultiplier);
               else
                    rb.velocity = transform.up * (-speed+(SlowMultiplier*enemyCount));

        scrollVelocity = rb.velocity;
        Debug.Log(scrollVelocity.y);

    }
}
