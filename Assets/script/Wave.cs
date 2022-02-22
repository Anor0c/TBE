using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject en;
    public GameObject en2;
    public GameObject boss;
    GameObject[] enemy;
    private int EnemyCount;
    public int waveCount;
    public int waveToBoss;

    public void Start()
    {
        waveCount = 0;
    }

    public void Boss()
    {
        if (waveToBoss < waveCount)
        {
            Instantiate(boss);
        }
    }
    public void Spawn()
    {
        Instantiate(en);
        Instantiate(en2);
        Boss();
        waveCount++;
    }
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("enemi");
        EnemyCount = enemy.Length;
        if (EnemyCount == 0)
        {
            Spawn();
        }

        
    }
}
