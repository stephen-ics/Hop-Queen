using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;

    void Start()
    {
        //resolutions = Screen.resolutions;

        //clear resolutions in dropdown
        //resolutionDropdown.ClearOptions();

        //list of options
        //List<string> options = new List<string>();

        //loop through each option in array
       // for (int i = 0; i < resolutions.Length; i++)
        {
            //create string to display resolution
            //string option = resolutions[i].width + "x" + resolutions[i].height;
            //add to options list
            //options.Add(options);
        }

        //add options list to resolution dropdown
        //resolutionDropdown.AddOptions(options);
        
    }
    public void SetFullScreen(bool isFullscreen)
    {
        //If toggle is fullscreen, true, otherwise, false
        Screen.fullScreen = isFullscreen;
    }
    public void setQuality(int qualityIndex)
    {
        //quality index selected in dropdown set as quality 
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    
}
