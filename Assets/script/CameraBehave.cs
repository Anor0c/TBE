using UnityEngine;
using UnityEngine.Events;
using System;

public class CameraBehave : MonoBehaviour
{
    [SerializeField] UnityEvent onBgBossOnScreen;
    public Transform[] bg;
    public Transform bgBoss1, bgBoss2;

    [SerializeReference] private Transform BG5,BG1;
    private float sizebg;
    public int lastIndex, currentIndex;
    public bool isBoss;
    void Start()
    {
        BG5 = bg[4];
        BG1 = bg[0];
        sizebg = bg[0].GetComponent<BoxCollider2D>().size.y;
        isBoss = false;
    }

    void FixedUpdate()
    {

        foreach (Transform t in bg)
        {
            if (this.transform.position.y >= (t.position.y + 22))
            {
                t.position = new Vector3(t.position.x, t.position.y + (sizebg * 5), t.position.z);
                currentIndex = Array.IndexOf(bg, t);
                lastIndex = Array.IndexOf(bg, t) - 1;
                //SwitchBG();
            }
        }
        if (lastIndex > bg.Length)
        {
            lastIndex = 0;
        }
        if (isBoss && currentIndex == 3)
        {
            onBgBossOnScreen?.Invoke();
        }
        else
            return;
    }
    
    public void BGBoss()
    {
        var indexLastBG = Array.IndexOf(bg, BG5);
        var indexFirstBG = Array.IndexOf(bg, BG1);
        bg[indexLastBG] = bgBoss1;
        bg[indexFirstBG] = bgBoss2;
        isBoss = true;
    }
}
