using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManage : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public Text CoinsTXT;
    private bool isEquipped;
    private bool owned;
    public int id;



    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "Coins: " + Inventory.coins.ToString();

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

        id = (ButtonRef.GetComponent<ButtonInfo>().ItemID) - 1;
        owned = Inventory.ownedCosmetics[id];
        

        if ((Inventory.coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID]) && (!owned))
        {
            Inventory.coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            CoinsTXT.text = "Coins: " + Inventory.coins.ToString();
            Inventory.ownedCosmetics[id] = true;
        }

        else if (owned)
        {
            isEquipped = Inventory.equippedCosmetics[id];

            for (int i = 0; i < Inventory.equippedCosmetics.Length; i++)
            {
                Inventory.equippedCosmetics[i] = false;
            }

            if (isEquipped)
            {
                Inventory.equippedCosmetics[id] = false;
            }
            else
            {
                Inventory.equippedCosmetics[id] = true;
                CosmeticID.currentID = id;
            }
        }
    }
}
