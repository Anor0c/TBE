using UnityEngine;
using System.Collections;
public class continu : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //début du compte a rebourmkfrsjg
    private Coroutine rafaleCoroutine;
    public GameObject bullet;
    public Transform point;
    public int damage = 40;
    public float waitRafale;
    private player playervar;


    public void Start()
    {
        playervar = GameObject.FindObjectOfType<player>();
        time = startTime;
        var rafale = waitRafale ;
        if (rafale !=0)
        {
            rafaleCoroutine=StartCoroutine(RafaleCoroutine());
            
        }
    }

    void Update()
    {
        if (playervar != null)
        {
            if (rafaleCoroutine == null)
            {
                if (time <= 0)
                {
                    Instantiate(bullet, point.position, Quaternion.identity);
                    time = startTime;
                }
                else
                {
                    time -= Time.deltaTime;
                }
            }
        }
    }
    IEnumerator RafaleCoroutine()
    {
        while (time>0)
        {
            Instantiate(bullet, point.position, Quaternion.identity);
            time -= Time.deltaTime;
            Debug.Log("Bullet!"); 
        }
        new WaitForSeconds(waitRafale);
        time = startTime;
        yield return null;

    }
}

