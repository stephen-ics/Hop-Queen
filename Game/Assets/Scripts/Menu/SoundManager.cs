using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Object that is responsible for the volume's slider volume chanign ability
/// </summary>
public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        //If no save data, set volume to max
        if (!PlayerPrefs.HasKey("musicVolume")) 
        {
            PlayerPrefs.SetFloat("musicVollume", 1);
            Load();
        }
        //Otherwise, set to pre-designated value
        else
        {
            Load();
        }
    }

   /// <summary>
   /// Stores volume of game as the volume (value) of the slider
   /// </summary>
   public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    /// <summary>
    /// Set value of vloume slider to the stored volume in the key name
    /// </summary>
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    /// <summary>
    /// Stores the value of the volume slider in the key name
    /// </summary>
    public void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
