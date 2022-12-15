using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Object that sets the label value equal to that of the volume
/// </summary>
public class TextSlider : MonoBehaviour
{
    /// <summary>
    /// Text that is being altered
    /// </summary>
   public TextMeshProUGUI numberText;
   
    /// <summary>
    /// Sets the text to the value of the slider
    /// </summary>
    /// <param name="value"> volume slider value as a float </param>
   public void SetNumberText(float value)
    {
        numberText.text = value.ToString();
    }


}
