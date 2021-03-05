using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level2Manager : MonoBehaviour
{

    public static int score1;
    public Text score1Text;

    // Use this for initialization
    void Start()
    {
        score1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score1Text.text = "Points: " + score1; //show score
    }

    public static void AddPoints(int points1)
    {
        score1 = score1 + points1;
    }
}