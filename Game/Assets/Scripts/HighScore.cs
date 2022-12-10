using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
    
{
    public TMP_Text highscore;
    float highscoreval = 0;
    // Start is called before the first frame update
    void Start()
    {
        highscoreval = PlayerPrefs.GetFloat("HighScore", Stopwatch.finishedTime);
        highscore.text = highscoreval.ToString();
        //highscore.text = PlayerPrefs.GetFloat("HighScore", 100000).ToString();
       
    }

    // Update is called once per frame
    void Update()
    {
        highscoreval = PlayerPrefs.GetFloat("HighScore", Stopwatch.finishedTime);
        highscore.text = highscoreval.ToString();
        Debug.Log(Stopwatch.finishedTime);
    }

    public void SetHighScore()
    {
        if (highscoreval > Stopwatch.finishedTime)
        //if (PlayerPrefs.GetFloat("HighScore", 100000) > Stopwatch.finishedTime)
        {
            PlayerPrefs.SetFloat("HighScore", Stopwatch.finishedTime);
            highscore.text = Stopwatch.finishedTime.ToString();
        }
    }
}
