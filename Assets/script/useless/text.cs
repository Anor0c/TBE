using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text textbox;
  

    void Start()
    {
        textbox = GetComponent<Text>();
    }

    void Update(int health)
    {

        textbox.text = "" + health;

        if (health <= 0)
            Destroy(gameObject);

    }
}
