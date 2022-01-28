using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundBulletBurst : MonoBehaviour
{
    public float startTime; //temps entre chaque tir
    private float time; //début du compte a rebourmkfrsjg
    public GameObject bullet;
    public Transform[] arrayCanon;
    public Transform canon;
    public int lengh;
    public Transform point;
    public int damage = 40;
    [HideInInspector] public Vector2 direction;

    void Start()
    {
        time = startTime;
        arrayCanon = new Transform [lengh];
       
    }

    void Update()
    {
       for (int nb = 0; nb < arrayCanon.Length; nb++) {
            Transform clone = Instantiate(canon, canon.position , Quaternion.identity);
            arrayCanon[nb] = clone;
        }
        foreach (Transform canon in arrayCanon)
        {
            // logique pour faire un array de canon qui pointe en rond 
        }
    }
}