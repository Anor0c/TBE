using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
public class Wave : MonoBehaviour
{
    [SerializeField] UnityEvent onPlayerJoined;
    private Coroutine spawnWait;

    public GameObject[] enList;
    public GameObject boss;
    private Enemy[] enemyScene;
    public Wave[] wavesInScene;
    [HideInInspector] public ScrollControl _scrollControl;

    public int enemyCount;
    public int waveCount;
    public int waveToBoss;
    public int waitForSpawn;
    public bool coroutineIsRunning = false;

    public void Start()
    {
        wavesInScene = FindObjectsOfType<Wave>();
        if (wavesInScene.Length <= 1)
            waveCount = 0;
        else
            waveCount = wavesInScene[0].waveCount;

    }
    public void OnPlayer2Joined()
    {
        onPlayerJoined.Invoke();
    }
    public void DeactivateEnemyOnDeath()
    {
        foreach (Enemy en in enemyScene)
        {
            en.gameObject.SetActive(false);
        }
    }

    public void Boss()
    {
        if (waveToBoss < waveCount)
        {
            Instantiate(boss, this.gameObject.transform);
        }
    }
    public void Spawn()
    {
        waveCount++;
        Instantiate(enList[0], this.gameObject.transform);
        Instantiate(enList[1], this.gameObject.transform);
        Instantiate(enList[2], this.gameObject.transform);
        Boss();
    }
    private IEnumerator SpawnWait()
    {
        coroutineIsRunning = true;
        yield return new WaitForSeconds(waitForSpawn);
        Spawn();
        yield return null;
    }
    void Update()
    {
        enemyScene = GetComponentsInChildren<Enemy>();
        enemyCount = enemyScene.Length;
        if (enemyCount == 0)
        {
            if (coroutineIsRunning) 
                return;

            spawnWait=StartCoroutine(SpawnWait());
            //Spawn();
            //il faudrait une coroutine qui s'invoque une seule fois pour lancer un wait de genre 2 secondes avant de lancer  
            //je peut peut etre untiliser wavecount pour lancer la coroutine une seule fois
        }
        else
        {
            if (spawnWait != null)
            {
                StopCoroutine(spawnWait);
                coroutineIsRunning = false;
                Debug.Log("pls stop");
            }
        }

        if (PlayerInputManager.instance.playerCount == 2)
            OnPlayer2Joined();   
    }
}
