using UnityEngine;
using System;

public class CameraBehave : MonoBehaviour
{
    public Transform[] bg;
    private float sizebg;
    private int lastIndex, currentIndex;
    void Start()
    {
        sizebg = bg[0].GetComponent<BoxCollider2D>().size.y;
    }

    void FixedUpdate()
    {
        foreach (Transform t in bg) 
        {
            if (this.transform.position.y >= (t.position.y+20))
            {
                t.position = new Vector3(t.position.x, t.position.y + (sizebg * 4), t.position.z);
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
}
