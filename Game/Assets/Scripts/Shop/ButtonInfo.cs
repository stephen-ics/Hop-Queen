using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text StatusTxt;
    public GameObject ShopManager;
    public GameObject checkMark;

    // Update is called once per frame
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
