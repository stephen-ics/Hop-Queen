using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniversalLevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int level = LevelSelector.selectedLevel;
        Debug.Log(level);
    }
    public void GoBackToLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
