using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2 : MonoBehaviour
{

    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;



    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player2");
    }

    public void TakeDamage(int damage)
    {
      health-=damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        healthBar.UpdateHealthBar();
    }
}
