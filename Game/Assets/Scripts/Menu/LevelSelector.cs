using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Object that transports user to their desired level/scene
/// </summary>
public class LevelSelector : MonoBehaviour
{
    /// <summary>
    /// Level selected by the user
    /// </summary>
    public int level;

    /// <summary>
    /// Transitions the user the their desired level using the index selected
    /// </summary>
    public void OpenScene()
    {
        SceneManager.LoadScene("Level" + level.ToString());
    }

}
