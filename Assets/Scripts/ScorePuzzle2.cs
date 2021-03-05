using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScorePuzzle2 : MonoBehaviour
{

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
        scoreTextPuzzle.text = scorePuzzle + "/" + 48;
        if (scorePuzzle == 48)//condition for next level
        {
            nextLevelButton.SetActive(true);
        }
    }

    public static void AddPoints(int points)
    {
        scorePuzzle = scorePuzzle + points;
    }
}
