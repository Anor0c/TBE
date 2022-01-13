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


    void Start()
    {
        time = startTime;
        var rafale = GetComponent<RafaleEnemy>();
        if (rafale !=null)
        {
            rafaleCoroutine=StartCoroutine(RafaleCoroutine());
            
        }
    }

    void Update()
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
    IEnumerator RafaleCoroutine()
    {
        while (time>0)
        {
            Instantiate(bullet, point.position, Quaternion.identity);
            time -= Time.deltaTime;
            // Rajouter le Cooldown pour la rafale+dédoublerla raffale
        }
        yield return null;
    }
}

