using UnityEngine;

public class bulletenemi : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public float damage = 40;
    public player player;
    Vector2 moveDirection;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<player>();
        moveDirection = (player.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }
   
        void OnTriggerEnter2D(Collider2D hitInfo)
        {
            player enemi = hitInfo.GetComponent<player>();
            if (enemi != null)
            {
                enemi.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
}
