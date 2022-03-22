using UnityEngine;

public class PlayerDoT : MonoBehaviour
{
    public float damage = 1;
    private Enemy enemi;

    void OnTriggerStay2D(Collider2D hitInfo)
    {
        Enemy enemi = hitInfo.GetComponent<Enemy>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
    }
}
