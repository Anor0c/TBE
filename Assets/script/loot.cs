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
            joueur.GunLevelUp();
            Destroy(gameObject);
        }
        
    }
}