using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level3Manager : MonoBehaviour
{

    public static int score2;
    public Text score2Text;


    // Use this for initialization
    void Start()
    {
        score2 = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        score2Text.text = "Points: " + score2; //show score
    }

    public static void AddPoints(int points2)
    {
        score2 = score2 + points2;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("Level 3");
    }

}