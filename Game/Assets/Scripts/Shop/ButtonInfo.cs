using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Stores the info on each item and determines which aspects between status text and the equipped checkmark are displayed
/// </summary>
public class ButtonInfo : MonoBehaviour
{
    /// <summary>
    /// The ID of the item as an int
    /// </summary>
    public int ItemID;
    /// <summary>
    /// The price text as a Text
    /// </summary>
    public Text PriceTxt;
    /// <summary>
    /// The status text as a Text
    /// </summary>
    public Text StatusTxt;
    /// <summary>
    /// The ShopManager as a GameObject
    /// </summary>
    public GameObject ShopManager;
    /// <summary>
    /// The checkMark as a GameObject
    /// </summary>
    public GameObject checkMark;

    /// <summary>
    /// Sets the status text and the equipped checkmark
    /// </summary>
    void Update()
    {
        // Updates the price text for each item
        PriceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManage>().shopItems[2, ItemID].ToString();

        // Check and display if items are owned or not owned
        if (Inventory.ownedCosmetics[ItemID-1])
        {
            StatusTxt.text = "Owned: Yes";
        }
        else
        {
            StatusTxt.text = "Owned: No";
        }

        // Checks if the player is currently equipping the item to determine whether or not to display the green square
        if (Inventory.equippedCosmetics[ItemID-1])
        {
            checkMark.SetActive(true);
        }
        else
        {
            checkMark.SetActive(false);
        }
    }
}
