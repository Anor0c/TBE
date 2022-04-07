using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float maxHealth , health;

    public EnnemiHealthBar enemyhealthbar;
    public ScrollControl _scrollControl;
    private EnemyCounter counter;
    private ItemDrop getItem;

    private void Start()
    {
        getItem = GetComponent<ItemDrop>();
        counter = GetComponentInParent<EnemyCounter>();
        health = maxHealth;
    }



    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            if (counter == null)
                return;
            Death();
            counter.IncrementCountEnemy();

        }
        enemyhealthbar.UpdateEnemyHealthBar();
    }
    public void Death()
    {
        if (getItem != null)
        {
            getItem.DropItem();
            Debug.Log("Dropped an Item " + getItem);
            Destroy(this.gameObject);
        }

    }
}
