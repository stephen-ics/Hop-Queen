using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

/// <summary>
/// Determines which sprite is rendered according to the list of sprites and current sprite equipped
/// </summary>
public class Cosmetics : MonoBehaviour
{
    /// <summary>
    /// Stores the list of possible sprites to be displayed 
    /// </summary>
    public Sprite[] spriteList;

    /// <summary>
    /// Sets the sprite of the player according to the current cosmetic of the player
    /// </summary>
    void Update()
    { 
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[(Inventory.currentID)];
    }
}
