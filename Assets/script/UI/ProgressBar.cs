using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [HideInInspector] public Image _progresBar;
    [SerializeField] private int totalEnemy;

    private void Start()
    {
        _progresBar = this.GetComponent<Image>();
    }

    public void ProgressBarUpdate(int currentEnemyKilled)
    {
        _progresBar.fillAmount = Mathf.Clamp(currentEnemyKilled / totalEnemy, 0, 1);
    }
}
