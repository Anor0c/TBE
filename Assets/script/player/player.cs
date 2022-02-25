using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;


    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player1");
    }
    public void TakeDamage(float damage)
    {
      health-=damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else { return; }
        healthBar.UpdateHealthBar();
    }
 }
