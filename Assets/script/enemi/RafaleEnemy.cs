using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafaleEnemy : MonoBehaviour
{
    public player player;
    public float startTime;
    private float time;
    [HideInInspector]public Vector2 moveDirection;
    public float decalX, decalY;
    public GameObject bullet;
    public Transform point;
    public float rafaleInterval;
    private IEnumerator rafaleCoroutine;
    void Start()
    {
        player = GameObject.FindObjectOfType<player>();
        startTime = time;
        StartCoroutine(RafaleCoroutine());
    }
    private void Update()
    {
        moveDirection = transform.localRotation * transform.up;
        
    }
    public IEnumerator RafaleCoroutine()
    {
        while (time >0)
        {
            Instantiate(bullet, point.transform.position, point.rotation);
            Debug.Log("bullet!");
            
        }
        time -= Time.deltaTime;

        yield return new WaitForSeconds(rafaleInterval);
    }

}
