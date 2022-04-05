using UnityEngine.Events;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public int enemyCount;
    public UnityEvent<int> onEnemyDied;

    public void IncrementCountEnemy()
    {
        enemyCount++;
        onEnemyDied.Invoke(enemyCount);
    }
}
