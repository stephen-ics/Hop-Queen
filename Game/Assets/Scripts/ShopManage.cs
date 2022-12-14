using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManage : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public static float coins;
    public Text CoinsTXT;
    private bool isEquipped;

    private CosmeticID id;


    // Start is called before the first frame update
    void Start()
    {
        coins = 100;

        CoinsTXT.text = "Coins: " + coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Quantity
        shopItems[3, 1] = 10;
        shopItems[3, 2] = 20;
        shopItems[3, 3] = 30;
        shopItems[3, 4] = 40;

    }

    // Update is called once per frame
    public void Buy()
    { 
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject[] cosmeticsList = GameObject.FindGameObjectsWithTag("Item");
 
        if ((coins >= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID]) && (!ButtonRef.GetComponent<ButtonInfo>().owned))
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            CoinsTXT.text = "Coins: " + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().owned = true;
        }

        else if (ButtonRef.GetComponent<ButtonInfo>().owned)
        {
            isEquipped = ButtonRef.GetComponent<ButtonInfo>().equipped;
            print(isEquipped);
            print("asdsad");

            foreach (GameObject cosmetic in cosmeticsList)
            {
                cosmetic.GetComponent<ButtonInfo>().equipped = false;
            }
 
            if (isEquipped)
            {
                ButtonRef.GetComponent<ButtonInfo>().equipped = false;
            }
            else
            {
                ButtonRef.GetComponent<ButtonInfo>().equipped = true;
                print("adsad");
                print(id.currentID.ToString());
                id.currentID = ButtonRef.GetComponent<ButtonInfo>().ItemID;
            }
        }
    }
}
