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
    /// Gets the ID of the item
    /// </summary>
    public int ItemID;
    /// <summary>
    /// Gets the price text
    /// </summary>
    public Text PriceTxt;
    /// <summary>
    /// Gets the status text
    /// </summary>
    public Text StatusTxt;
    /// <summary>
    /// Gets the ShopManager GameObject
    /// </summary>
    public GameObject ShopManager;
    /// <summary>
    /// Gets the checkMark GameObject
    /// </summary>
    public GameObject checkMark;

    /// <summary>
    /// Sets the status text and the equipped checkmark
    /// </summary>
    void Update()
    {
        PriceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManage>().shopItems[2, ItemID].ToString();

        if (Inventory.ownedCosmetics[ItemID-1])
        {
            StatusTxt.text = "Owned: Yes";
        }
        else
        {
            StatusTxt.text = "Owned: No";
        }


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
