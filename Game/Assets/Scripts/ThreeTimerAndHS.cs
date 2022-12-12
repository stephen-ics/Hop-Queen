using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Object that starts and stops timer as well as sets and deletes a new high score for level three
/// </summary>
public class ThreeTimerAndHS : MonoBehaviour
{
    /// <summary>
    /// Time variable with placeholder value of 0
    /// </summary>
    private int time = 0;
    /// <summary>
    /// Timer text
    /// </summary>
    public TMP_Text timer;
    /// <summary>
    /// High score text
    /// </summary>
    public TMP_Text highscorethree;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighscoreThree") == true)
        {
            highscorethree.text = PlayerPrefs.GetInt("HighscoreThree").ToString();
        }
        else
        {
            highscorethree.text = "N/A";
        }
    }
    /// <summary>
    /// When set active (by button), increase time
    /// </summary>
    public void StartTimerThree()
    {
        time = 0;
        InvokeRepeating("IncrimentTimeThree", 1, 1);
    }
    /// <summary>
    /// When set active (by button), stop incrementing time and replace high score if less than current high score
    /// </summary>
    public void StopTimerThree()
    {
        CancelInvoke();
        if (time < PlayerPrefs.GetInt("HighscoreThree"))
        {
            SetHighscoreThree();
        }
        else if (highscorethree.text == "N/A")
        {
            SetHighscoreThree();
        }

    }
    /// <summary>
    /// Sets new highscore
    /// </summary>
    public void SetHighscoreThree()
    {
        PlayerPrefs.SetInt("HighscoreThree", time);
        highscorethree.text = PlayerPrefs.GetInt("HighscoreThree").ToString();

    }
    /// <summary>
    /// Clears current high score
    /// </summary>
    public void ClearHighscoresThree()
    {
        PlayerPrefs.DeleteKey("HighscoreThree");
        highscorethree.text = "N/A";
    }
    /// <summary>
    /// Increments the time by 1 every second
    /// </summary>
    void IncrimentTimeThree()
    {
        time += 1;
        timer.text = "Time: " + time;
    }
}
