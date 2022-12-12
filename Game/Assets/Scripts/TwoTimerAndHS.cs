using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Object that starts and stops timer as well as sets and deletes a new high score for level two
/// </summary>
public class TwoTimerAndHS : MonoBehaviour
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
    public TMP_Text highscoretwo;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighscoreTwo") == true)
        {
            highscoretwo.text = PlayerPrefs.GetInt("HighscoreTwo").ToString();
        }
        else
        {
            highscoretwo.text = "N/A";
        }
    }

    /// <summary>
    /// When set active (by button), increase time
    /// </summary>
    public void StartTimer()
    {
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }
    /// <summary>
    /// When set active (by button), stop incrementing time and replace high score if less than current high score
    /// </summary>
    public void StopTimer()
    {
        CancelInvoke();
        if (time < PlayerPrefs.GetInt("HighscoreTwo\""))
        {
            SetHighscore();
        }
        else if (highscoretwo.text == "N/A")
        {
            SetHighscore();
        }

    }
    /// <summary>
    /// Sets new highscore
    /// </summary>
    public void SetHighscore()
    {
        PlayerPrefs.SetInt("HighscoreTwo", time);
        highscoretwo.text = PlayerPrefs.GetInt("HighscoreTwo").ToString();

    }
    /// <summary>
    /// Clears current high score
    /// </summary>
    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("HighscoreTwo");
        highscoretwo.text = "N/A";
    }
    /// <summary>
    /// Increments the time by 1 every second
    /// </summary>
    void IncrimentTime()
    {
        time += 1;
        timer.text = "Time: " + time;
    }
}
