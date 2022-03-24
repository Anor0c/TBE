using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else { return; }
        healthBar.UpdateHealthBar();
    }
}
