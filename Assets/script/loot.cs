using UnityEngine.InputSystem;
using UnityEngine;

public class loot : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    gunLevelUp joueur;


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("çatouche");
        /*player joueur = hitInfo.GetComponent<player>();
        joueur = hitInfo.tag == "Player";
        if (joueur != null)
        {
            joueur.GunLevelUp();
            Destroy(gameObject);
        }*/


        
        if (hitInfo.tag == "Player")
        {
            Debug.Log(hitInfo);
            joueur = hitInfo.GetComponent<gunLevelUp>();
            joueur.GunLevelUp();
            Destroy(gameObject);
        }
    }
}