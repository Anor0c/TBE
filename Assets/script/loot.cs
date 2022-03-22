using UnityEngine.InputSystem;
using UnityEngine;

public class Loot : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public gunLevelUp joueur;
    PlayerMode player;


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
        //player = GameObject.FindGameObjectWithTag("Player");
        //joueur.GetComponent<gunLevelUp>().GunLevelUp(); //add
        player = GetComponent<PlayerMode>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //joueur = hitInfo.tag == "Player";
        /*if (player != null)
        {
            Debug.Log("çatouche");
            joueur.GunLevelUp();
        }*/

        Destroy(gameObject);

        if (hitInfo.tag == "Player")
        {
            Debug.Log("touche");
            //Debug.Log(hitInfo);
            //joueur = hitInfo.GetComponent<gunLevelUp>();
            joueur.GunLevelUp();
        }
        
    }
}