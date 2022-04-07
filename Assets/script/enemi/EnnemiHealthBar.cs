using UnityEngine;
using UnityEngine.UI;
public class EnnemiHealthBar : MonoBehaviour
{
    public Image healthBarEnemy;
    [HideInInspector] public Enemy enemy;

    private void Start()
    {
        enemy = this.gameObject.GetComponentInParent<Enemy>();
    }
    public void UpdateEnemyHealthBar()
    {
        healthBarEnemy.fillAmount = Mathf.Clamp(enemy.health / enemy.maxHealth, 0, 1f);
    }
}