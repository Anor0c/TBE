using UnityEngine;
using System.Collections;
public class continu : MonoBehaviour
{
    public enum FireTempo
    {
        Auto,
        Burst
    }
    [SerializeField] private FireTempo CurrentEnemyTempo;
    public float firerate; 
    private float timeBeforeShoot;
    public int timesToShoot;
    public float burstpause;
    public GameObject bullet;
    public Transform point;
    public int damage = 40;
    private player playervar;
    private bool shooting;


    public void Start()
    {
        playervar = GameObject.FindObjectOfType<player>();
        timeBeforeShoot = 1 / firerate; 
       
    }
    void Update()
    {
        if (playervar != null)
        {
            switch (CurrentEnemyTempo)
            {
                case FireTempo.Auto:
                    if (playervar != null)
                        Auto();
                    break;

                case FireTempo.Burst:
                    if (playervar != null)
                        Rafale();
                    break;
            }
        }
        else { return; }
    }
    void Rafale()
    {
        StartCoroutine(RafaleCoroutine(timesToShoot));
    }
    /*IEnumerator BurstPause()
    {
        if (!shooting)
        {
            shooting = true;
            new WaitForSeconds(burstpause);
            StartCoroutine(RafaleCoroutine(timesToShoot));
            yield return null;
        }
    }*/
    void Auto()
    {
        
        {
            if (timeBeforeShoot  <= 0)
            {
                Instantiate(bullet, point.position, Quaternion.identity);
                timeBeforeShoot=1/firerate;
            }
            else
            {
                timeBeforeShoot -= Time.deltaTime;
            }
        }
    }
    
    IEnumerator RafaleCoroutine(int timesToShoot)
    {
        for (int timesShot = 1; timesShot <= timesToShoot; timesShot++) ; 
        {
                Instantiate(bullet, point.position, Quaternion.identity);
                Debug.Log("Bullet!");
            shooting = false;
            yield return new WaitForSeconds(1 / firerate);
        }
    }
}

