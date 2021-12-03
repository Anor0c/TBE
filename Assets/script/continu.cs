using UnityEngine;

public class continu : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //début du compte a rebourmkfrsjg
    public GameObject bullet;
    public Transform point;
    //Rigidbody2D rb;
    [SerializeField] float speed;
    public int damage = 40;
    


    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        time = startTime;
        //rb.velocity = transform.up * speed;
    }

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(bullet, point.position, Quaternion.identity);
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }



        
    }

    //void OnTriggerEnter2D(Collider2D hitInfo)
    //{


       // player enemi = hitInfo.GetComponent<player>();
        //if (enemi != null)
        //{
          //  enemi.TakeDamage(damage);
       // }
        //Destroy(gameObject);
    //}
    


}

