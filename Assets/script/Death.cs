using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private Animator animator;
    public float life;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        this.transform.parent.GetComponent<Enemy>().health = life;
    }
    void Start()
    {
        
        animator.SetBool("IsAlive", true);
        
    }
    void Update()
    {
        if (life <= 0)
        {
            animator.SetBool("IsAlive", false);
        }
        
    }
}
