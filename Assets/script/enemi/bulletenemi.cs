using UnityEngine;

public class bulletenemi : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public float damage = 40;
    [HideInInspector] public PlayerMode player;
    Vector2 moveDirection;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<PlayerMode>();
        moveDirection = (player.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        HealthBehaviour enemi = hitInfo.GetComponent<HealthBehaviour>();
        if (enemi != null)
        {
            enemi.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
