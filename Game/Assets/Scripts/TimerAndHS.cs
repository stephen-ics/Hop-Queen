using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerAndHS : MonoBehaviour
{
    private int time = 0;
    public TMP_Text timer;
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

    public void StartTimer()
    {
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }

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

    public void SetHighscore()
    {
        PlayerPrefs.SetInt("Highscore", time);
        highscore.text = PlayerPrefs.GetInt("Highscore").ToString();

    }

    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("Highscore");
        highscore.text = "N/A";
    }

    void IncrimentTime()
    {
        time += 1;
        timer.text = "Time: " + time;
    }
}