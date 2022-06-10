using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float maxHealth , health;

    public EnnemiHealthBar enemyhealthbar;
    public ScrollControl _scrollControl;
    public Transform spawnPoint1, spawnPoint2;

    [SerializeField] private bool isBoss;
    [SerializeField] private bool isCyclope;
    [SerializeField] Enemy cyclopeLantSpawn;

    private EnemyCounter counter;
    private ItemDrop getItem;
    private BossDeathWin bossWin;
    private Wave wave;

    private void Start()
    {
        getItem = GetComponent<ItemDrop>();
        counter = GetComponentInParent<EnemyCounter>();
        bossWin = GetComponentInParent<BossDeathWin>();
        health = maxHealth;
        if (isCyclope)
            wave = GetComponentInParent<Wave>();
    }



    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Death();
            counter.IncrementCountEnemy();
            if (counter == null)
                return;

        }
        enemyhealthbar.UpdateEnemyHealthBar();
    }
    public void Death()
    {
        if (!isBoss)
        {
            if (!isCyclope)
            {

                if (getItem != null)
                {
                    getItem.DropItem();
                    Debug.Log("Dropped an Item " + getItem);
                }
                Destroy(this.gameObject);
            }
            else
                CyclopeDeath();
            
        }
        else
            bossWin.BossDied();
    }
    private void CyclopeDeath()
    {
        Instantiate(cyclopeLantSpawn, spawnPoint2.position, Quaternion.identity, wave.gameObject.transform);
        Instantiate(cyclopeLantSpawn, spawnPoint1.position, Quaternion.identity, wave.gameObject.transform);
        isCyclope = false;
    }
}
