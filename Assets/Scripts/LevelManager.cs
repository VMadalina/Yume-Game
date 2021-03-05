using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static int score ;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Points: " + score; //show score
    }

    public static void AddPoints(int points)
    {
        score= score+ points;
    }
}