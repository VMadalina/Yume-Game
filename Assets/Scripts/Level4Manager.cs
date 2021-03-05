using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level4Manager : MonoBehaviour
{

    public static int score3;
    public Text score3Text;


    // Use this for initialization
    void Start()
    {
        score3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score3Text.text = "Points: " + score3; //show score
    }

    public static void AddPoints(int points3)
    {
        score3 = score3 + points3;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("Level 4");
    }

}