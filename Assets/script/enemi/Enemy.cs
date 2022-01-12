using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float maxHealth , health;
    public GameObject enemyPrefab;
    public Transform point;
    public EnnemiHealthBar enemyhealthbar;
    private ItemDrop getItem;

    private void Start()
    {
        //enemies = FindGameObjectWithTag("Enemy");
        //enemies = FindGameObjectsWithTag("Enemy"); enemies[0],enemies[1]
        getItem = GetComponent<ItemDrop>();

    }


    public void spawn()
    {
        Instantiate(enemyPrefab, point.position, Quaternion.identity);
    }


    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            if (getItem != null)
            {
                getItem.DropItem();
                Debug.Log("Dropped an Item " + getItem);
                
            }

            
            Destroy(gameObject);
            spawn();
        }
        enemyhealthbar.UpdateEnemyHealthBar();
    }
}
