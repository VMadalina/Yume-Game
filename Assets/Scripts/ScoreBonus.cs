using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : MonoBehaviour {

    public int starValue;
    public static int bonusScore;
    public Text scoreText;

    // Use this for initialization
    void Start ()
    {
        bonusScore = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Points: " + bonusScore;
    }

    void OnTriggerEnter2D ()
    {
        bonusScore+= starValue;
    }

}
