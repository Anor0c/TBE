using UnityEngine;


public class ItemDrop : MonoBehaviour
{
    [SerializeField]
    private GameObject[] itemList; // Stores the game items
    private int itemNum; // Selects a number to choose from the itemList
    private int randNum; // chooses a random number to see if loot os dropped- Loot chance
    private Transform Epos; // enemy position


    private void Start()
    {
        // itemList = CamFollow.itemListPass;
        Epos = GetComponent<Transform>();
        Debug.Log(itemList);
    }

    public void DropItem()
    {



        randNum = Random.Range(0, 100); // 100% total for determining loot chance;
        Debug.Log("Random Number is " + randNum);


        if (randNum <= 33) // Star Tablet drop itemList[2] currently
        {
            itemNum = 2;// grabs the star tab
            Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);


        }
        else if (randNum > 33 && randNum <= 66) // Extra life drop itemList[1] currently
        {

            itemNum = 1;// grabs the star tab
            Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);

        }
        else if (randNum > 66 && randNum <= 100)// Health Heart drop itemList[0] currently
        {

            itemNum = 0;// grabs the star tab
            Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);

        }


    }
}
