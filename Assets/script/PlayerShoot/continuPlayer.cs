using UnityEngine;

public class continuPlayer : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //début du compte a rebourmkfrsjg
    public GameObject bullet;
    public Transform point;
    public int GunLevel=0;
    [HideInInspector] public Vector2 direction;

    public GameObject TourelleOn;
    public GameObject TourelleOff;
    
    void Start()
    {
        time = startTime;
        TourelleOn.SetActive(true);
        TourelleOff.SetActive(false);

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
