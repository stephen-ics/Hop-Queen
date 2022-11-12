using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public static int selectedLevel;
    public int level;
    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        //levelText.text = level.ToString();
    }

    public void OpenScene()
    {
        selectedLevel = level;
        SceneManager.LoadScene(2);
        //SceneManager.LoadScene("Level" + level.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
