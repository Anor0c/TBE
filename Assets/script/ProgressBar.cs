using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image _progresBar;
    private int totalEnemy;
    [HideInInspector] public int currentEnemyKilled;
    // Start is called before the first frame update
public void ProgressBarUpdate()
    {
        _progresBar.fillAmount = Mathf.Clamp(currentEnemyKilled / totalEnemy, 0, 1);
    }
}
