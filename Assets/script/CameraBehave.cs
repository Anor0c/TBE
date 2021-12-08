using UnityEngine;

public class CameraBehave : MonoBehaviour
{
    public Transform target, bg1, bg2;
    private float size;
    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;   
    }

    void FixedUpdate()
    {
        Vector3 TargetPos = new Vector3(target.position.x, target.position.y, -10);
        transform.position = TargetPos;
        if (transform.position.y>=bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x, bg2.position.y+size, bg1.position.z);
            SwitchBG();
        }
    }
    private void SwitchBG()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp; 
    }
}
