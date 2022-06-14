using UnityEngine;
using System;

public class CameraBehave : MonoBehaviour
{
    public Transform[] bg;
    public Transform bgBoss1, bgBoss2;

    private float sizebg;
    private int lastIndex, currentIndex;
    private bool isBoss;
    void Start()
    {
        sizebg = bg[0].GetComponent<BoxCollider2D>().size.y;
        isBoss = false;
    }

    void FixedUpdate()
    {
        foreach (Transform t in bg) 
        {
            if (this.transform.position.y >= (t.position.y+20))
            {
                t.position = new Vector3(t.position.x, t.position.y + (sizebg * 5), t.position.z);
                currentIndex = Array.IndexOf(bg, t);
                lastIndex = Array.IndexOf(bg, t)-1;
                SwitchBG();
            }
        }
        if (lastIndex > bg.Length) 
        {
            lastIndex = 0;
        }
    }
    private void SwitchBG()
    {

        Transform temp = bg[lastIndex];
        bg[lastIndex] = bg[currentIndex];
        bg[currentIndex] = temp; 
    }
    public void BGBoss()
    {
        bg[4] = null;
        bg[4] = bgBoss1;
        isBoss = true;
    }
}
