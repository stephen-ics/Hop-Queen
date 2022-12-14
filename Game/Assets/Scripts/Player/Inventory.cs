using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the players inventory, containing the number of coins, owned cosmetics, equipped cosmetics, and the currentID of the sprite equipped
/// </summary>
public class Inventory : MonoBehaviour
{
    /// <summary>
    /// Gets the number of coins 
    /// </summary>
    public static int coins = 100;
    /// <summary>
    /// Gets the status of the cosmetics on whether they are owned
    /// </summary>
    public static bool[] ownedCosmetics = new[] { false, false, false, false };
    /// <summary>
    /// Gets the status of the owned cosmetics on whether they are equiped
    /// </summary>
    public static bool[] equippedCosmetics = new[] { false, false, false, false };
    /// <summary>
    /// Gets the currentID of the equipped cosmetic
    /// </summary>
    public static int currentID;


}
