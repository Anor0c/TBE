using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;
    public int GunLevelRequirement;
    continuPlayer[] Cplayer;

    private void Start()
    {
        Cplayer = transform.GetComponentsInChildren<continuPlayer>();
        foreach (continuPlayer point in Cplayer)
        {
            //point.isActive = true;
            if (point.GunLevel != 0)
            {
                point.gameObject.SetActive(false);
            }
        }
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
    public void GunLevelUp()
    {

        GunLevelRequirement++;
        foreach(continuPlayer point in Cplayer)
        {
            if (GunLevelRequirement >= point.GunLevel)
            {
                point.gameObject.SetActive(true);
            }
        }
    }
 }
