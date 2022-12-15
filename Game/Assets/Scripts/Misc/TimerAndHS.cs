using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Object that starts and stops timer as well as sets and deletes a new high score for level one
/// </summary>
public class TimerAndHS : MonoBehaviour
{
    /// <summary>
    /// Time variable with placeholder value of 0 as an integer
    /// </summary>
    private int time = 0;
    /// <summary>
    /// Timer text
    /// </summary>
    public TMP_Text timer;
    /// <summary>
    /// High score text
    /// </summary>
    public TMP_Text highscore;

    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            highscore.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
        else
        {
            highscore.text = "N/A";
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
        if (time < PlayerPrefs.GetInt("Highscore")) 
        {
            SetHighscore();
        }
        else if (highscore.text == "N/A")
        {
            SetHighscore();
        }

    }
    /// <summary>
    /// Sets new highscore
    /// </summary>
    public void SetHighscore()
    {
        PlayerPrefs.SetInt("Highscore", time);
        highscore.text = PlayerPrefs.GetInt("Highscore").ToString();

    }
    /// <summary>
    /// Clears current high score
    /// </summary>
    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("Highscore");
        highscore.text = "N/A";
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