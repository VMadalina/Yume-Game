using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevelButton : MonoBehaviour {

    int sceneIndex;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1); ;
        PlayerPrefs.SetInt("LevelPassed", sceneIndex);
    }
}
