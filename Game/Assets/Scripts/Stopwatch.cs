using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public TMP_Text currentTimeText;
    private float finishedTime;
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
        finishedTime = currentTime;
    }
    public void StartStopwatch()
    {
        stopwatchActive = true; 
    }
    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
        
}
