using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoT : MonoBehaviour
{
    public float damage = 1;
    private Enemy enemi;
    void Start()
    {
        enemi  = GameObject.FindObjectOfType<Enemy>();
    }
    void OnTriggerStay2D(Collider2D hitInfo)
    {
         enemi = hitInfo.GetComponent<Enemy >();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
    }
}
