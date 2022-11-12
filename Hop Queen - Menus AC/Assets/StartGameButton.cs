using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGameButton : MonoBehaviour
{
    // Build number of scene to start when start button is pressed
    public int gameStartScene;

    // Start is called before the first frame update
    public void StartGame() {
        SceneManager.LoadScene(gameStartScene);
    }
}
