using UnityEngine.InputSystem;
using UnityEngine;

public class loot : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        player joueur = hitInfo.GetComponent<player>();
        if (joueur != null)
        {


            //code pour ajouter leffet quand le drop rentre en contact avec le player

            


            Destroy(gameObject);
            this.GetComponent<arme>().enabled = false;
        }
        
    }
}