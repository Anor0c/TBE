using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    [SerializeField] float speed;
    private Transform player;
    private Vector2 cible;
    //Rigidbody2D rb;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cible=new Vector2(player.position.x, player.position.y);
        //rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = player.transform.position * speed;

    }

    void Update()
    {
        //transform.LookAt(player
        //rb.AddForce(cible * speed);
        transform.position = Vector2.MoveTowards(transform.position, cible, speed * Time.deltaTime);
        //transform.Translate(Vector2.up * speed * Time.deltaTime); les bullets evitent le player
    }
}
