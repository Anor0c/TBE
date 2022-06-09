using UnityEngine;
using UnityEngine.InputSystem;

public class bulletenemi : MonoBehaviour
{
    [SerializeField] private float speed;
    public PlayerMode[] playerList;
    public float damage = 40;

    [HideInInspector] public PlayerMode player;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        playerList = FindObjectsOfType<PlayerMode>();

        if (PlayerInputManager.instance.playerCount == 0) 
            rb.velocity = Vector2.down * speed;
        else
        {
            if (PlayerInputManager.instance.playerCount == 1) 
                player = playerList[0];

            if (PlayerInputManager.instance.playerCount >= 2) 
            {
                if (transform.position.x > 800)
                    player = playerList[0];
                else
                    player = playerList[1];
            }
            moveDirection = (player.transform.position - transform.position).normalized * speed;
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        }
        Debug.Log(player);
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
