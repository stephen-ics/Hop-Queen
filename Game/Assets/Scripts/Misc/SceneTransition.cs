using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Transports the player to a different scene on collision
/// </summary>
public class SceneTransition : MonoBehaviour
{
    /// <summary>
    /// Stores the name of the scene to be transported to as a string
    /// </summary>
    public string sceneName;

    /// <summary>
    /// Loads the new scene when the player collided with player
    /// </summary>
    public void OnTriggerEnter2D(Collider2D other)
    {
        // Checks if other object is a Player
        if (other.CompareTag("Player"))
        {
            // Load scene and add 50 coins to the Player
            SceneManager.LoadScene(sceneName);
            Inventory.coins += 50;
        }
    }

}
