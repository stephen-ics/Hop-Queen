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
    /// Stores the info on the different shop items as a 2D int array
    /// </summary>
    public int[,] shopItems = new int[5, 5];
    /// <summary>
    /// Gets the coins text
    /// </summary>
    public Text CoinsTXT;
    /// <summary>
    /// Whether or not the selected item is currently equipped as a boolean
    /// </summary>
    private bool isEquipped;
    /// <summary>
    /// Whether or not the selected item is currently owned as a boolean
    /// </summary>
    private bool owned;
    /// <summary>
    /// The id of the items as an int
    /// </summary>
    public int id;
    /// <summary>
    /// The current button the player is clicking on as a GameObject
    /// </summary>
    GameObject ButtonRef;
    /// <summary>
    /// The list of cosmetics that are considered items as an array of GameObjects
    /// </summary>
    GameObject[] cosmeticsList;

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
    /// When clicked, buy the item if the player has enough money, and the item is not owned, or else equip or unequip the item
    /// </summary>
    public void HandleClick()
    {
        // Initializing variables for current selected item
        ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        cosmeticsList = GameObject.FindGameObjectsWithTag("Item");
        id = (ButtonRef.GetComponent<ButtonInfo>().ItemID) - 1;
        owned = Inventory.ownedCosmetics[id];


        // Check the status of the item
        if ((Inventory.coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID]) && (!owned))
        {
            // If the player has enough coins and item is not owned, buy item
            Inventory.coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            CoinsTXT.text = "Coins: " + Inventory.coins.ToString();
            Inventory.ownedCosmetics[id] = true;
        }

        else if (owned)
        {
            // If item is owned check if it is equipped
            isEquipped = Inventory.equippedCosmetics[id];

            // Unequip all items
            for (int i = 0; i < Inventory.equippedCosmetics.Length; i++)
            {
                Inventory.equippedCosmetics[i] = false;
            }

            // Check if item is equipped
            if (isEquipped)
            {
                // If item is equipped, unequip the item
                Inventory.equippedCosmetics[id] = false;
            }
            else
            {
                // If item is unequipped, equip the item
                Inventory.equippedCosmetics[id] = true;
                Inventory.currentID = id;
            }
        }
    }
}
