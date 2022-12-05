using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that sends the user to the level selection scene to start the game
/// </summary>
public class StartGameButton : MonoBehaviour
{
    // Build number of scene to start when start button is pressed
    public int gameStartScene;

    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
