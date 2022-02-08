using UnityEngine.InputSystem;
using UnityEngine;

public class Loot : MonoBehaviour
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
        Player joueur = hitInfo.GetComponent<Player>();
        if (joueur != null)
        {
            joueur.GunLevelUp();
            Destroy(gameObject);
        }
        
    }
}