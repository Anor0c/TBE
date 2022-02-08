using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;
    public int GunLevelRequirement;
    ContinuPlayer[] Cplayer;

    private void Start()
    {
        Cplayer = transform.GetComponentsInChildren<ContinuPlayer>();
        foreach (ContinuPlayer point in Cplayer)
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
        foreach(ContinuPlayer point in Cplayer)
        {
            if (GunLevelRequirement >= point.GunLevel)
            {
                point.gameObject.SetActive(true);
            }
        }
    }
 }
