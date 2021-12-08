using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Enemy enemy;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
    void Update()
    {
        
    }
}
