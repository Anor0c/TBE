using UnityEngine;

public class ScrollControl : MonoBehaviour
{
    public Wave enemiesInScenes;
    [SerializeField] float speed;
    [HideInInspector] public Rigidbody2D rb;
    GameObject[] enemy;
    private int EnemyCount;
    public float SlowMultiplier;
    [HideInInspector] public Vector2 scrollVelocity;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -speed;
        
    }
    void Update()
    {
        EnemyCount = enemiesInScenes.enList.Length;
        if (EnemyCount <= 0)
                    rb.velocity = transform.up *(-speed-10);
               else
                    rb.velocity = transform.up * (-speed+(SlowMultiplier*EnemyCount));

                scrollVelocity = rb.velocity;
    }
}
