using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that transports user to the tutorial
/// </summary>
public class TutorialSelect : MonoBehaviour
{

    /// <summary>
    /// Transitions the user the tutorial
    /// </summary>
    public void OpenScene()
    {
        SceneManager.LoadScene(2);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ComesticsHandler : MonoBehaviour
{
    public Sprite[] spriteList;
    public int currentSprite;


    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<SpriteRenderer>().sprite = spriteList[currentSprite];
    }
}
