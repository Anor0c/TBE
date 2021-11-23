using UnityEngine.InputSystem;
using UnityEngine;

public class armed : MonoBehaviour
{

    public Transform point; //r�cup la position de d�part des balles
    public GameObject bulletPrefabDroite;
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
        Instantiate(bulletPrefabDroite, point.position, point.rotation);
    }


    void shoot(InputAction.CallbackContext context)
    {
        Shoot();
    }


}
