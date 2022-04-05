using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float maxHealth , health;
    //public GameObject enemyPrefab;
    //public Transform point;
    public EnnemiHealthBar enemyhealthbar;
    private ItemDrop getItem;

    private void Start()
    {
        getItem = GetComponent<ItemDrop>();

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
            var counter = GetComponent<EnemyCounter>();
            counter.IncrementCountEnemy();
        }
        enemyhealthbar.UpdateEnemyHealthBar();
    }
}
