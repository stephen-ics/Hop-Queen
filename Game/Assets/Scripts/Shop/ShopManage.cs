using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Manages the shop which allows the player to buy, equip, and unequip cosmetics from the shop
/// </summary>
public class ShopManage : MonoBehaviour
{
    /// <summary>
    /// Gets the info on the different shop items
    /// </summary>
    public int[,] shopItems = new int[5, 5];
    /// <summary>
    /// Gets the coins text
    /// </summary>
    public Text CoinsTXT;
    /// <summary>
    /// Gets whether or not the selected item is currently equipped
    /// </summary>
    private bool isEquipped;
    /// <summary>
    /// Gets whether or not the selected item is currently owned
    /// </summary>
    private bool owned;
    /// <summary>
    /// Gets the id of the items
    /// </summary>
    public int id;



    /// <summary>
    /// Sets the info for all the shop items and display the coins text
    /// </summary>
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

    /// <summary>
    /// When clicked, buy the item if the item is not owned and the player has enough money, or else equip or unequip the item
    /// </summary>
    public void HandleClick()
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
                Inventory.currentID = id;
            }
        }
    }
}
