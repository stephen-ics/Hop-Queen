using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

/// <summary>
/// Object running the options in the settings menu (Quality, Fullscreen)
/// </summary>
public class SettingsMenu : MonoBehaviour
{
    /// <summary>
    /// Allows user to toggle in and out of fullscreen
    /// </summary>
    /// <param name="isFullscreen"> Judges whether toggle is on or off </param>
    public void SetFullScreen(bool isFullscreen)
    {
        //If toggle is fullscreen, true, otherwise, false
        Screen.fullScreen = isFullscreen;
    }
    /// <summary>
    /// Allows user to select their desired quality of game
    /// </summary>
    /// <param name="qualityIndex"> quality index choice </param>
    public void setQuality(int qualityIndex)
    {
        //quality index selected in dropdown set as quality 
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    
}
