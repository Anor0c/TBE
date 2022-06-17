using UnityEngine;
using UnityEngine.Events;

public class BossHpSwitch : MonoBehaviour
{
    private Enemy enemy;
    private continu gun;
    [SerializeField] UnityEvent onSwitch; 
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Enemy>();        
    }
    private void Update()
    {
        if (enemy.health <= 300)
            BossSwitch();
        return;
    }
    void BossSwitch()
    {
        onSwitch?.Invoke();
    }
}
