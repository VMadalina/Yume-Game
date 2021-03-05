using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level4BonusManager : MonoBehaviour {

    private static int score;
    public GameObject nextLevelButton;

    public Camera cam;
    public GameObject star;
    public float timeLeft;
    public Text timerText;
    private float maxWidth;
    public GameObject tryAgainText, restartButton, targetButton;
    private bool playing;
   

    //Use this for initialization
    void Start()
    {
        nextLevelButton.SetActive(false);
        playing = false;
        if(cam ==null )
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float starWidth =star.GetComponent< Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - starWidth;
        UpdateText();
    }

     void Update()
    {
        score = ScoreBonus.bonusScore;
    }

    void FixedUpdate() // decrease of time
    {
        if (playing == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0) //not have negative time
            {
                timeLeft = 0;
            }
            UpdateText();
        }
    }

    public void StartLevel()
    {
        targetButton.SetActive(false);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn () // appear star
    {
        yield return new WaitForSeconds(2.0f);
        playing = true;
        while (timeLeft>0)
         {
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth),7.0f, 0.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(star, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(0.7f, 1.0f));
        }

        if (score >= 30 && timeLeft == 0)//condition for next level
        {
            nextLevelButton.SetActive(true);
        }
        else
        {
            yield return new WaitForSeconds(1.7f);
            tryAgainText.SetActive(true);
            yield return new WaitForSeconds(1.2f);
            restartButton.SetActive(true);
        }
    }

    void UpdateText()
    {
        timerText.text = "Time left: " + Mathf.RoundToInt(timeLeft);
    }
}