using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the players inventory containing the number of coins, owned cosmetics, equipped cosmetics, and the currentID of the sprite equipped
/// </summary>
public class Inventory : MonoBehaviour
{
    /// <summary>
    /// The number of coins as an int
    /// </summary>
    public static int coins = 0;
    /// <summary>
    /// The status of the cosmetics on whether they are owned as an array of booleans
    /// </summary>
    public static bool[] ownedCosmetics = new[] { false, false, false, false };
    /// <summary>
    /// The status of the owned cosmetics on whether they are equipped as an array of booleans
    /// </summary>
    public static bool[] equippedCosmetics = new[] { false, false, false, false };
    /// <summary>
    /// The currentID of the equipped cosmetic as an integer
    /// </summary>
    public static int currentID;


}
