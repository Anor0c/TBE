using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;

    public SpriteRenderer spriteRenderer;
    public Sprite high;
    public Sprite mid;
    public Sprite low;

    public HealthBar healthBar;
    [SerializeField] UnityEvent onPlayerDied;


    public void TakeDamage(float damage)
    {
        health -= damage;

        healthBar.UpdateHealthBar();

        if (health < 500)
            spriteRenderer.sprite = high;

        if (health < 300)
            spriteRenderer.sprite = mid;

        if (health < 200)
            spriteRenderer.sprite = low;

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
