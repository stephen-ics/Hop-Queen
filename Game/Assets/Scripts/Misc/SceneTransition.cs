using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Transports the player to a different scene on collision
/// </summary>
public class SceneTransition : MonoBehaviour
{
    /// <summary>
    /// Stores the name of the scene to be transported to
    /// </summary>
    public string sceneName;

    /// <summary>
    /// Loads the new scene when the player collides with itself
    /// </summary>
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
            Inventory.coins += 50;
        }
    }

}
