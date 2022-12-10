using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwoTimerAndHS : MonoBehaviour
{
    private int time = 0;
    public TMP_Text timer;
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

    public void StartTimer()
    {
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }

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

    public void SetHighscore()
    {
        PlayerPrefs.SetInt("HighscoreTwo", time);
        highscoretwo.text = PlayerPrefs.GetInt("HighscoreTwo").ToString();

    }

    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("HighscoreTwo");
        highscoretwo.text = "N/A";
    }

    void IncrimentTime()
    {
        time += 1;
        timer.text = "Time: " + time;
    }
}
