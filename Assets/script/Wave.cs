using System.Collections.Generic;
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

    private int EnemyCount;
    public int waveCount;
    public int waveToBoss;

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
        Instantiate(enList[2], this.gameObject.transform);
        Boss();
        waveCount++;
    }
    void Update()
    {
        enemyScene = GetComponentsInChildren<Enemy>();
        EnemyCount = enemyScene.Length;
        if (EnemyCount == 0)
        {
            Spawn();
        }
        if (PlayerInputManager.instance.playerCount == 2)
            OnPlayer2Joined();
            //il faudrait une facon de compter des ennemis seulement sur l'écran de P1, et de spawner des ennemis a P2 genre en faisant instanciate(en, en.position.xs+1000) 
            //apres on fait la meme update qu'avec P1 mais avec un tag différent
        
    }
}
