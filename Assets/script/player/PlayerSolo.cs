using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSolo : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;

    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        healthBar.UpdateHealthBar();
    }
}