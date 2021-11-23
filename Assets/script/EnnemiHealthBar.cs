using UnityEngine;
using UnityEngine.UI;
public class EnnemiHealthBar : MonoBehaviour
{
    public Image healthBarEnemy;
    public Enemy enemy;
    public void UpdateEnemyHealthBar()
    {
        healthBarEnemy.fillAmount = Mathf.Clamp(enemy.health / enemy.maxHealth, 0, 1f);
    }
}