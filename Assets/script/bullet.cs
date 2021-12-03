using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public int damage = 40;

    void Start()
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
