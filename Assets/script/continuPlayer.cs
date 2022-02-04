using UnityEngine;

public class continuPlayer : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //début du compte a rebourmkfrsjg
    public GameObject bullet;
    public Transform point;
    public int damage = 40;
    public int GunLevel=0;
    [HideInInspector] public Vector2 direction;
    
    void Start()
    {
        time = startTime;
    }

    void Update()
    {
        direction = transform.localRotation * transform.up;
        if (time <= 0)
        {
            Instantiate(bullet, point.position, point.rotation);
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
