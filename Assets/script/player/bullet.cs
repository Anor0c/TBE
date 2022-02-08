using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public float damage = 40f;
    [HideInInspector] public Vector2 direction;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemi = hitInfo.GetComponent<Enemy>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
