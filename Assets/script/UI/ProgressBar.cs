using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image _progresBar;
    [SerializeField] private int totalEnemy=5;

    private void Awake()
    {
        _progresBar = this.GetComponent<Image>();
    }

    public void ProgressBarUpdate(int currentEnemyKilled)
    {
        _progresBar.fillAmount = Mathf.Clamp(currentEnemyKilled / totalEnemy, 0f, 1f);
        Debug.Log(currentEnemyKilled);
        Debug.Log(_progresBar.fillAmount);
    }
}
