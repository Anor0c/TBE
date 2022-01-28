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
    private float lastShot;
    private float timePause;
    private int shotCount;
    public int burstCount;
    public float burstpause;
    public GameObject bullet;
    public Transform point;
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
                        Auto();
                    break;

                case FireTempo.Burst:
                        Rafale();
                    break;
            }
        }
        else { return; }
    }
    void Rafale()
    {
        var waitTime = lastShot + timePause;
        if (Time.time > waitTime) 
        {

            lastShot = Time.time;
            Instantiate(bullet, point.position, point.rotation);
            Debug.Log("shotCount=" + shotCount);
            shotCount++;

        }
        if (shotCount == burstCount+1)
        {
            timePause += burstpause;
            shotCount = 0;
        }
        else if(shotCount ==1)
        {
            timePause = 1/firerate;
        }
    }
 
    void Auto()
    {
        
        {
            if (timeBeforeShoot  <= 0) 
            {
                Instantiate(bullet, point.position, point.rotation);
                timeBeforeShoot=1/firerate;
                Debug.Log("Auto Bullet!");
            }
            else
            {
                timeBeforeShoot -= Time.deltaTime;
            }
        }
    }
    
    /*IEnumerator RafaleCoroutine(int timesToShoot)
    {
        for (int timesShot = 1; timesShot <= timesToShoot; timesShot++)
        {
            Instantiate(bullet, point.position, point.rotation);
            Debug.Log("Burst Bullet!");
            shooting = false;
            yield return new WaitForSeconds(1 / firerate);
        }
    }*/
}

