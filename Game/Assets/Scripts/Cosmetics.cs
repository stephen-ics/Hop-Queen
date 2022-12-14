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
    private CosmeticID id;

    // Update is called once per frame
    void Update()
    {
        print(id.currentID);
        Player.GetComponent<SpriteRenderer>().sprite = spriteList[id.currentID];
    }
}
