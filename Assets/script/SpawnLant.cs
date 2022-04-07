using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLant : MonoBehaviour
{
    //public Enemy Alive;
    public float Life;
    public GameObject lanterne1, lanterne2;
    public GameObject Spawn1, Spawn2;
    void Start()
    {

    }
    void Update()
    {
        var place = FindObjectOfType<SpawnLant>().transform;
        Life = GetComponent<Enemy>().health;

        if (Life <= 0)
        {
            Instantiate(lanterne1, place);
            Instantiate(lanterne2, Spawn2.transform);
            Destroy(gameObject);
        }
    }
}