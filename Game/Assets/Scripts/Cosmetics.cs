using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Cosmetics : MonoBehaviour
{
    public Sprite[] spriteList;
    public int spriteID;
    public static int currentSprite;
    public GameObject Player;
    public Sprite testSprite;

    // Update is called once per frame
    void Update()
    {
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[(Inventory.currentID)];
    }
}
