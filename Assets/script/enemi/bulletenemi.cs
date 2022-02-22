using UnityEngine;

public class bulletenemi : MonoBehaviour
{
    [SerializeField] float speed;
    //Rigidbody2D rb;
    public int damage = 40;
    private Transform player;
    private Vector2 cible;
    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cible = new Vector2(player.position.x, player.position.y);

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, cible, speed * Time.deltaTime);
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
