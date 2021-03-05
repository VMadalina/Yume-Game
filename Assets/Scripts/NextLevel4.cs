using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel4 : MonoBehaviour
{

    public GameObject nextLevelButton;

    //Use this for initialization
    void Start()
    {
        nextLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update() 
    {
        if (Level5Manager.score4 >= 530) //appear next level button when condition is true
        {
            nextLevelButton.SetActive(true);
        }
        else
            nextLevelButton.SetActive(false);
    }
}
