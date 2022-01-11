using UnityEngine;

public class continuPlayer : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //d�but du compte a rebourmkfrsjg
    public GameObject bullet;
    public Transform point;
    Rigidbody2D rb;
    [SerializeField] float speed;
    public int damage = 40;
    public int GunLevel;
    public bool isActive = false;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        time = startTime;
        rb.velocity = transform.up * speed;
    }

    void Update()
    {
        if(!isActive)
        {
            return;
        }
        if (time <= 0)
        {
            Instantiate(bullet, point.position, Quaternion.identity);
            //Instantiate(bulletg, pointg.position, Quaternion.identity);
            //Instantiate(bulletd, pointd.position, Quaternion.identity);
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
