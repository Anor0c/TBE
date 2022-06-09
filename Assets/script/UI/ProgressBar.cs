using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image _progresBar;
    [SerializeField] private int totalEnemy=5;

    private void Awake()
    {
        _progresBar = this.GetComponent<Image>();
        _progresBar.fillAmount = 0;
    }

    public void ProgressBarUpdate(int currentEnemyKilled)
    {
        float currentFloatEnemyKilled = (float)currentEnemyKilled;
        _progresBar.fillAmount = Mathf.Clamp(currentFloatEnemyKilled / totalEnemy, 0, 1f);
        Debug.Log("Ennemis tués"+currentEnemyKilled);
        Debug.Log("Fraction de Barre Remplies"+_progresBar.fillAmount);
    }
}
