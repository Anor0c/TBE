using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollControl : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    GameObject enemy;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
    void Update()
    {

    }
}
