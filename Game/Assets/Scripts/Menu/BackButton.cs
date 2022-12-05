using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that returns user to Main Menu 
/// </summary>
public class BackButton : MonoBehaviour
{
    
    /// <summary>
    /// Transitions user to the desired index of scene 0 (Menu)
    /// </summary>
    public void OpenScene()
    {
        SceneManager.LoadScene(0);
    }
   
}
