using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that sends the user to the scene selected by the index number
/// </summary>
public class StartGameButton : MonoBehaviour
{
    /// <summary>
    /// Integer holding the scene index
    /// </summary>
    public int nextScene;

    /// <summary>
    /// Loads the desired scene
    /// </summary>
    public void StartGame() {
        SceneManager.LoadScene(nextScene);
    }
}
