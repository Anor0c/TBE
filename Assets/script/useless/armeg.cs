using UnityEngine.InputSystem;
using UnityEngine;

public class armeg : MonoBehaviour
{

    public Transform point; //récup la position de départ des balles
    public GameObject bulletPrefabGauche;
    Rigidbody2D rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    void Update()
    {



    }

    public void Shoot()
    {
        Instantiate(bulletPrefabGauche, point.position, point.rotation);
    }


    void shoot(InputAction.CallbackContext context)
    {
        Shoot();
    }


}
