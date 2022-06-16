using UnityEngine;
using System.Collections.Generic;

public class ScrollControl : MonoBehaviour
{
    public Wave _wave;
    public CameraBehave cam;
    [HideInInspector] public Vector2 scrollVelocity;
    [HideInInspector] public Rigidbody2D rb;

    [SerializeField] float speed;
    [SerializeField] int enemyCount;
    public float SlowMultiplier;
    public float fastMultiplier;
    public float slowTime;

    private float lastVelocity, currentSlowTime;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -speed;
        
    }
    void Update()
    {

            enemyCount = _wave.enemyCount;
            if (enemyCount <= 0)
                rb.velocity = transform.up * (-speed - fastMultiplier);
            else
                rb.velocity = transform.up * (-speed + (SlowMultiplier * enemyCount));

            scrollVelocity = rb.velocity;
            lastVelocity = rb.velocity.y;
            Debug.Log(scrollVelocity.y);
        
        return;

    }
    public void StopBGBoss()
    {
        rb.velocity = transform.up * 0;
    }
}
