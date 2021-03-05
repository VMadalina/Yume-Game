using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level5Manager : MonoBehaviour
{

    public static int score4;
    public Text score4Text;


    // Use this for initialization
    void Start()
    {
        score4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score4Text.text = "Points: " + score4;//show score
    }

    public static void AddPoints(int points4)
    {
        score4 = score4 + points4;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("Level 5");
    }

}