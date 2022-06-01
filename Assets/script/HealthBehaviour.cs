using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;

    public HealthBar healthBar;
    [SerializeField] UnityEvent onPlayerDied;


    public void TakeDamage(float damage)
    {
        health -= damage;

        healthBar.UpdateHealthBar();

        if (health <= 0)
            PlayerDied();
        // il faudrait un GameEvent ou un UnityEvent pour faire spawn un texte en mode "You Lose", une petite illustration, et pour despawn les enemis. 

        else { return; }
        healthBar.UpdateHealthBar();
    }
    public void PlayerDied()
    {
        onPlayerDied?.Invoke();
    }
    public void DestroyPlayerOnDeath()
    {
        Destroy(gameObject);
    }
}
