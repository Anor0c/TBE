using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2 : MonoBehaviour
{
    public GameObject gauche;
    Rigidbody2D rb;
    public float maxHealth = 500;
    public float health;
    public HealthBar healthBar;
    public int GunLevelRequirement;
    continuPlayer[] Cplayer;


    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player2");
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

    public void TakeDamage(int damage)
    {
      health-=damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        healthBar.UpdateHealthBar();
    }

    /*void OnTriggerEnter2D(Collider2D hitInfo) //pour activer l'upgrade
    {
        loot gain = hitInfo.GetComponent<loot>();
        if (gain != null)
        {


            gauche.SetActive(true);

        }
        TakeDamage(40);
    }*/
    public void GunLevelUp()
    {

        GunLevelRequirement++;
        foreach (continuPlayer point in Cplayer)
        {
            if (GunLevelRequirement >= point.GunLevel)
            {
                point.gameObject.SetActive(true);
            }
        }
    }
}
