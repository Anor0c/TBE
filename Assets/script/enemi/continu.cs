using UnityEngine;
using System.Collections;
public class continu : MonoBehaviour
{
    public enum FireTempo
    {
        Auto,
        Burst,
        BurstHeal
    }
    [SerializeField] private FireTempo CurrentEnemyTempo;
    public float firerate; 
    private float timeBeforeShoot;


    private float lastShot;
    private float timePause;
    private int shotCount;
    public int burstCount;
    public float burstpause;
    public bool isMelee;


    public GameObject bullet;
    public GameObject heal;
    public Transform point;
    private HealthBehaviour playervar;


    public void Start()
    {
        timeBeforeShoot = 1 / firerate;
        burstCount = burstCount - 1;
    }
    void Update()
    {
        playervar = GameObject.FindObjectOfType<HealthBehaviour>();
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
                case FireTempo.BurstHeal:
                    BurstHeal();
                    break;
            }
        }
        else { return; }
    }
    void Shoot(GameObject prefabToShoot)
    {
        if (!isMelee)
            Instantiate(prefabToShoot, point.position, point.rotation);
        else
            Instantiate(prefabToShoot, point.position, point.rotation, this.gameObject.transform);
        shotCount++;
    }
    void Rafale()
    {
        //Utiliser une Guarding case et revoir le code 
        var waitTime = lastShot + timePause;
        if (Time.time < waitTime)
        {
            return;
        }

        // il faudrait un moyen pour instanc un heal sur le 1er proj
        if (shotCount == burstCount + 1)
        {
            timePause += burstpause;
            shotCount = 0;
            Shoot(bullet);
        }
        else if (shotCount == 1)
        {
            timePause = 1 / firerate;
            Shoot(bullet);
            lastShot = Time.time;
        }
        else
        {
            Shoot(bullet);
            lastShot = Time.time;
            Debug.Log("shotCount=" + shotCount);
        }
    }

    void Auto()
    {
        
        {
            if (timeBeforeShoot  <= 0) 
            {
                Shoot(bullet);
                timeBeforeShoot=1/firerate;
                Debug.Log("Auto Bullet!");
            }
            else
            {
                timeBeforeShoot -= Time.deltaTime;
            }
        }
    }
    void BurstHeal()
    {
        //Utiliser une Guarding case et revoir le code 
        var waitTime = lastShot + timePause;
        if (Time.time < waitTime)
        {
            return;
        }
        
// il faudrait un moyen pour instanc un heal sur le 1er proj
        if (shotCount == burstCount + 1)
        {
            timePause += burstpause;
            shotCount = 0;
            Shoot(heal);
        }
        else if (shotCount == 1)
        {
            timePause = 1 / firerate;
            Shoot(bullet);
            lastShot = Time.time;
        }
        else
        {
            Shoot(bullet);
            lastShot = Time.time;
            Debug.Log("shotCount=" + shotCount);
        }
    }
  public void SwitchBoss()
    {
        CurrentEnemyTempo = FireTempo.Auto;
        firerate = 3;
    }  
}

