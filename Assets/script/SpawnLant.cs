using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLant : MonoBehaviour
{
    //public Enemy Alive;
    public float Life;
    public GameObject lanternes;
    //public GameObject Spawn1, Spawn2;
    void Start()
    {

    }
    void Update()
    {
        //var place = FindObjectOfType<SpawnLant>().transform;
        //var place2 = gameObject.find("Spawn1").transform;
        Life = GetComponent<Enemy>().health;

        if (Life <= 0)
        {
            Instantiate(lanternes);
            //Instantiate(lanterne1, place);

            Destroy(this.gameObject);
        }
    }
}