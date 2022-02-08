using UnityEngine;

public class Bulletenemi : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public float damage = 40;
    public Player player;
    Vector2 moveDirection;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<Player>();
        moveDirection = (player.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }
   
        void OnTriggerEnter2D(Collider2D hitInfo)
        {
            Player enemi = hitInfo.GetComponent<Player>();
            if (enemi != null)
            {
                enemi.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
}
