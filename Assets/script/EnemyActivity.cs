using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivity : MonoBehaviour
{
    private ScrollControl _cam;
    private Rigidbody2D rb;
    private bool isActive = false;
    public GameObject enemy;
    public float timeToBool;
    // Start is called before the first frame update
    void Start()
    {
        _cam = GameObject.FindObjectOfType<ScrollControl>();
        rb = this.GetComponent<Rigidbody2D>();
        Invoke("SwitchBool", timeToBool);
    }
    void EnemyActivate(GameObject enemyToActivate)
    {
        Instantiate(enemyToActivate, transform.position, transform.rotation);
        isActive = false;
    }
    void SwitchBool()
    {
        isActive = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = _cam.scrollVelocity;
        if(isActive)
        {
            EnemyActivate(enemy);
        }
    }
}
