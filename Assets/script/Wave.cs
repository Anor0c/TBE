using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
public class Wave : MonoBehaviour
{
    public Wave[] wavesInScene;
    [SerializeField] UnityEvent onPlayerJoined;

    public GameObject[] enList;
    public GameObject boss;
    Enemy[] enemyScene;
    private Coroutine spawnWait;

    private int EnemyCount;
    public int waveCount;
    public int waveToBoss;
    public int waitForSpawn;

    public void Start()
    {
        wavesInScene = FindObjectsOfType<Wave>();
        if (wavesInScene.Length <= 1)
            waveCount = 0;
        else
            waveCount = wavesInScene[0].waveCount;
        Spawn();
    }
    public void OnPlayer2Joined()
    {
        onPlayerJoined.Invoke();
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
        Instantiate(enList[0], this.gameObject.transform);
        Instantiate(enList[1], this.gameObject.transform);
        Boss();
        waveCount++;
    }
    private IEnumerator SpawnWait()
    {
        new WaitForSeconds(waitForSpawn);
        Spawn();
        yield return null;
    }
    void Update()
    {
        enemyScene = GetComponentsInChildren<Enemy>();
        EnemyCount = enemyScene.Length;
        if (EnemyCount == 0)
        {
            if (spawnWait != null)
            {
                StopCoroutine(SpawnWait());
                Debug.Log("love when it wrks");
            }

            spawnWait = StartCoroutine(SpawnWait());
            //Spawn();
            //il faudrait une coroutine qui s'invoque une seule fois pour lancer un wait de genre 2 secondes avant de lancer  
        }
        if (PlayerInputManager.instance.playerCount == 2)
            OnPlayer2Joined();   
    }
}
