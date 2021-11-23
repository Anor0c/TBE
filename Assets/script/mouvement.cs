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
  
    void Update()
    {
        var stick2d = new Vector2(stickdirection.x, stickdirection.y);
        rb.velocity = stick2d * speed;
    }

    public void OnStickMove(InputAction.CallbackContext context)
    {
        stickdirection = context.ReadValue<Vector2>();
    }
}

