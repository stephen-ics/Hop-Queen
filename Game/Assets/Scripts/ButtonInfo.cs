using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;
    public GameObject checkMark;
    public bool owned = false;
    public bool equipped = false;
    public int currentlyEquipped = 1;

    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManage>().shopItems[2, ItemID].ToString();

        if (equipped)
        {
            checkMark.SetActive(true);
        }
        else
        {
            checkMark.SetActive(false);
        }

        
        if (!owned)
        {
            checkMark.SetActive(false);
        }
    }
}
