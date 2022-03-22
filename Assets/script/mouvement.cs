using UnityEngine.InputSystem;
using UnityEngine;

public class mouvement : MonoBehaviour
{

    [SerializeField] float speed;
    Vector2 stickdirection;

    Rigidbody2D rb; //pas oublier de mettre un rigid body 2d!!!

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  
    void FixedUpdate()
    {
        rb.velocity = stickdirection * speed;
    }

    public void OnMove(InputValue context)
    {
        stickdirection = context.Get<Vector2>();
        //Debug.Log("hehe");
    }
}

