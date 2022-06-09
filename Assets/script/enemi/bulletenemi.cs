using UnityEngine;

public class bulletenemi : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public float damage = 40;
    [HideInInspector] public PlayerMode player;
    Vector2 moveDirection;
    GameObject[] PlayerArray;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        /* if player != null
        return
        gameObject object[]
            if position > 900;
            player = gameObject[1]
            player = gameObject[0]*/
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
