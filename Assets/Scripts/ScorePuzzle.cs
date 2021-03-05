using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScorePuzzle : MonoBehaviour {

    public static int scorePuzzle;
    public Text scoreTextPuzzle;
    public GameObject nextLevelButton;

    // Use this for initialization
    void Start()
    {
        scorePuzzle = 0;
        nextLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextPuzzle.text = scorePuzzle + "/" +16;
        if(scorePuzzle ==16) //condition for next level
        {
            nextLevelButton.SetActive(true);
        }
    }

    public static void AddPoints(int points)
    {
        scorePuzzle = scorePuzzle + points;
    }
}
