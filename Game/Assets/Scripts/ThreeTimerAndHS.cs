using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThreeTimerAndHS : MonoBehaviour
{
    private int time = 0;
    public TMP_Text timer;
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

    public void StartTimer()
    {
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }

    public void StopTimer()
    {
        CancelInvoke();
        if (time < PlayerPrefs.GetInt("HighscoreThree"))
        {
            SetHighscore();
        }
        else if (highscorethree.text == "N/A")
        {
            SetHighscore();
        }

    }

    public void SetHighscore()
    {
        PlayerPrefs.SetInt("HighscoreThree", time);
        highscorethree.text = PlayerPrefs.GetInt("HighscoreThree").ToString();

    }

    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("HighscoreThree");
        highscorethree.text = "N/A";
    }

    void IncrimentTime()
    {
        time += 1;
        timer.text = "Time: " + time;
    }
}
