using UnityEngine;
using UnityEngine.InputSystem;
public class Wave : MonoBehaviour
{
    public ActWave2 actWave2;

    public GameObject[] enList;
    public GameObject[] enListP2;
    public GameObject boss;
    GameObject[] enemyScene;

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
        Instantiate(enList [0]);
        Instantiate(enList[1]);
        Boss();
        waveCount++;
    }
    void Update()
    {
        enemyScene = GameObject.FindGameObjectsWithTag("enemi");
        EnemyCount = enemyScene.Length;
        if (EnemyCount == 0)
        {
            Spawn();
        }
        if (PlayerInputManager.instance.playerCount == 2) 
        {
            Debug.Log("player 2 in");
            //il faudrait une facon de compter des ennemis seulement sur l'écran de P1, et de spawner des ennemis a P2 genre en faisant instanciate(en, en.position.xs+1000) 
            //apres on fait la meme update qu'avec P1 mais avec un tag différent
        }
    }
}
