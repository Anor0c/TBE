using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBehave : MonoBehaviour
{
    private ScrollControl _cam;
    private Rigidbody2D rb;
    public float delayParallax;
    // Start is called before the first frame update
    void Start()
    {
        _cam = GameObject.FindObjectOfType<ScrollControl>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = _cam.scrollVelocity * delayParallax; 
    }
}
