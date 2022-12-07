using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that open up pause menu while pausing the game
/// </summary>
public class pauseMenu : MonoBehaviour
{
    /// <summary>
    /// Bool to determine if game is paused/esc key pressed
    /// </summary>
    public static bool GameIsPaused = false;
    /// <summary>
    /// Unity UI element
    /// </summary>
    public GameObject pauseMenuUI;

    /// <summary>
    /// Checks if the escape key was pressed every frame
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    /// <summary>
    /// Resumes game if resume button pressed. Sets bool to false
    /// </summary>
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    /// <summary>
    /// Pauses game if escape button hit. Freezes the time and sets bool to true 
    /// </summary>
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    /// <summary>
    /// Unfreezes time and sends the user to the Menu scene. Sets bool to false
    /// </summary>
    public void LoadMenu()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Unfreezes time and sends the user to the Level select scene. Sets bool to false
    /// </summary>
    public void LoadLevel()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

}
