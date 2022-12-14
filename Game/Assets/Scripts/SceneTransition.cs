using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int index;
    public string levelName;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);
            SceneManager.LoadScene(levelName);
            Inventory.coins += 50;
        }
    }

}
