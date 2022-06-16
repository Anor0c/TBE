using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mood : MonoBehaviour
{
    public float life;

    public SpriteRenderer spriteRenderer;
    public Sprite high;
    public Sprite mid;
    public Sprite low;

    void Start()
    {
        GetComponent<HealthBehaviour>().health = life;
    }

    void Update()
    {
        GetComponent<HealthBehaviour>().health = life;

        if (life < 500)
            spriteRenderer.sprite = high;

        if (life < 300)
            spriteRenderer.sprite = mid;

        if (life < 200)
            spriteRenderer.sprite = low;

    }
}
