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
    /// Stores the list of possible sprites to be displayed as an array of sprites
    /// </summary>
    public Sprite[] spriteList;

    /// <summary>
    /// Sets the sprite of the player according to the current cosmetic of the player
    /// </summary>
    void Update()
    {
        // Sets the sprite renderer component in the selected game object to the currentID in the sprite list
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[(Inventory.currentID)];
    }
}
