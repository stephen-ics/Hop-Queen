using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that transports user to the tutorial
/// </summary>
public class TutorialSelect : MonoBehaviour
{

    /// <summary>
    /// Transitions the user the tutorial
    /// </summary>
    public void OpenScene()
    {
        SceneManager.LoadScene(2);
    }

}
