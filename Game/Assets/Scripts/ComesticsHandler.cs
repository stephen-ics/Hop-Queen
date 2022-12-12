using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ComesticsHandler : MonoBehaviour
{
    public Sprite[] spriteList;
    public int spriteId;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = spriteList[1];
        }

        
        
    }
    void changeSprite()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[spriteId];
    }
}
